using Cosmcs.Auth;
using Cosmcs.Base;
using Cosmcs.Broadcaster;
using Cosmcs.Crypto.Secp256k1;
using Cosmcs.Tx;
using DecentralCardGame.Cardchain.Cardchain;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace CardchainCs.CardchainClient;

public class CardchainClient
{
	public DefaultBroadcaster Broadcaster { get; }
	public JsonFormatter Formatter { get; }
	public JsonParser Parser { get; }
	public PrivateKey PrivateKey { get; }
	public BaseAccount BaseAccount { get; }
	public AccountId AccoutAddress { get; }
	public string ChainId { get; }

	public CardchainClient(string baseUrl, string chainId, byte[] bytes)
	{
		var reg = TypeRegistry.FromFiles(
			Cosmos.Auth.V1beta1.QueryReflection.Descriptor,
			Cosmos.Crypto.Secp256k1.KeysReflection.Descriptor,
			TxReflection.Descriptor
		);
		ChainId = chainId;
		Parser = new JsonParser(new JsonParser.Settings(20, reg));
		Formatter = new JsonFormatter(new JsonFormatter.Settings(true, reg));
		Broadcaster = new DefaultBroadcaster(baseUrl, Formatter, Parser);
		PrivateKey = new PrivateKey(bytes);
		AccoutAddress = PrivateKey.PublicKey().AccountId("cc");
		BaseAccount = GetBaseAccount();
	}

	private BaseAccount GetBaseAccount()
	{
		return BaseAccount.FromProto(
			Cosmos.Auth.V1beta1.BaseAccount.Parser.ParseFrom(
				QueryAccount(AccoutAddress.ToString()).Result.Account.Value
			)
		);
	}

	private Task<string> BuildAndBroadcast(Any msg)
	{
		var fee = new Fee(200_000);
		var body = new Builder().AddMsgs(new List<Any> { msg }).SetMemo("").Finish();
		var authInfo = new SignerInfo(PrivateKey.PublicKey().IntoSignerPublicKey(), BaseAccount.Sequence).AuthInfo(fee);
		var signDoc = new SignDoc(body, authInfo, ChainId, BaseAccount.AccountNumber);
		var txRaw = signDoc.Sign(PrivateKey);
		return txRaw.BroadcastCommit(Broadcaster).Result.ReadAsStringAsync();
	}

	public Task<Cosmos.Auth.V1beta1.QueryAccountResponse> QueryAccount(string addr)
	{
		return Broadcaster.Query<
			Cosmos.Auth.V1beta1.QueryAccountResponse
		>(
			$"cosmos/auth/v1beta1/accounts/{addr}"
		);
	}

	public Task<string> SendMsgBuyCardScheme(string bidAmout, string bidDenom)
	{
		return BuildAndBroadcast(
			new Any
			{
				Value = new MsgBuyCardScheme
				{
					Creator = AccoutAddress.ToString(),
					Bid = new Cosmos.Base.V1beta1.Coin
					{
						Amount = bidAmout,
						Denom = bidDenom
					}
				}.ToByteString(),
				TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgBuyCardScheme"
			}
		);
	}

	public Task<string> SendMsgExec(Any msg)
	{
		return BuildAndBroadcast(
			new Any
			{
				Value = new Cosmos.Authz.V1beta1.MsgExec
				{
					Grantee = AccoutAddress.ToString(),
					Msgs = { msg }
				}.ToByteString(),
				TypeUrl = "/cosmos.authz.v1beta1.MsgExec"
			}
		);
	}

	public Task<string> SendMsgExecMsgReportMatch(string playerA, string playerB, ulong[] cardsA, ulong[] cardsB)
	{
		var msg = new MsgReportMatch
		{
			Creator = AccoutAddress.ToString(),
			PlayerA = playerA,
			PlayerB = playerB,
		};
		msg.CardsA.AddRange(cardsA);
		msg.CardsB.AddRange(cardsB);

		return SendMsgExec(new Any
			{
				Value = msg.ToByteString(),
				TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgReportMatch"
			}
		);
	}

	public Task<string> SendMsgExecMsgVoteCard(ulong cardId, string voteType)
	{
		var msg = new MsgVoteCard
		{
			Creator = AccoutAddress.ToString(),
			CardId = cardId,
			VoteType = voteType,
		};

		return SendMsgExec(new Any
			{
				Value = msg.ToByteString(),
				TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgVoteCard"
			}
		);
	}
}