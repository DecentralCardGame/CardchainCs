using System.Net.Http.Headers;
using CardchainCs.CardchainClient;
using Cosmcs.Auth;
using Cosmcs.Base;
using Cosmcs.Broadcaster;
using Cosmcs.Crypto.Secp256k1;
using Cosmcs.Tx;
using DecentralCardGame.Cardchain.Cardchain;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using TxBody = Cosmos.Tx.V1beta1.TxBody;

var reg = TypeRegistry.FromFiles(
	Cosmos.Auth.V1beta1.QueryReflection.Descriptor,
	Cosmos.Crypto.Secp256k1.KeysReflection.Descriptor,
	DecentralCardGame.Cardchain.Cardchain.TxReflection.Descriptor);
var parser = new JsonParser(new JsonParser.Settings(20, reg));
var formater = new JsonFormatter(new JsonFormatter.Settings(true, reg));

var broadcaster = new DefaultBroadcaster("http://localhost:1317/", formater, parser);

using HttpClient httpClient = new();
httpClient.DefaultRequestHeaders.Accept.Clear();
httpClient.DefaultRequestHeaders.Accept.Add(
	new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
httpClient.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

byte[] hex = new byte[32]
{
	176, 139, 181, 219, 136, 19, 183,
	176, 135, 218, 199, 231, 70, 249,
	129, 238, 212, 197, 207, 147, 217,
	51, 43, 217, 82, 136, 182, 245,
	189, 104, 186, 17
};

var ccClient = new CardchainClient("http://localhost:1317/", hex);
Console.Out.WriteLine(ccClient.SendMsgBuyCardScheme("10000000000000000000", "ucredits").ReadAsStringAsync().Result);

return;

var accKey = new PrivateKey(hex);

var abc = broadcaster.Query<Cosmos.Auth.V1beta1.QueryAccountResponse>("cosmos/auth/v1beta1/accounts/cc1lm2h83f8nuatr8xqnwj4kr924xxzktal0fljsl").Result;

var baseAccount = BaseAccount.FromProto(Cosmos.Auth.V1beta1.BaseAccount.Parser.ParseFrom(abc.Account.Value));

Console.Out.WriteLine(baseAccount.Pubkey?.AccountId("cc"));

var msg = new Any
{
	Value = new MsgBuyCardScheme
	{
		Creator = "cc1lm2h83f8nuatr8xqnwj4kr924xxzktal0fljsl",
		Bid = new Cosmos.Base.V1beta1.Coin
		{
			Amount = "10000000000000000000",
			Denom = "ucredits"
		}
	}.ToByteString(),
	TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgBuyCardScheme"
};

var fee = new Fee(200_000);

var body = new Builder().AddMsgs(new List<Any> { msg }).SetMemo("").Finish();

var authInfo = new SignerInfo(accKey.PublicKey().IntoSignerPublicKey(), baseAccount.Sequence).AuthInfo(fee);

var signDoc = new SignDoc(body, authInfo, "Testnet3", baseAccount.AccountNumber);

var txRaw = signDoc.Sign(accKey);

Console.Out.WriteLine(formater.Format(TxBody.Parser.ParseFrom(txRaw.IntoProto().BodyBytes)));
Console.Out.WriteLine(formater.Format(Cosmos.Tx.V1beta1.AuthInfo.Parser.ParseFrom(txRaw.IntoProto().AuthInfoBytes)));
Console.Out.WriteLine(txRaw.IntoProto().Signatures);
Console.Out.WriteLine(Convert.ToHexString(txRaw.IntoProto().ToByteString().Span));

var result = txRaw.BroadcastCommit(broadcaster).Result;
Console.Out.WriteLine(result.ReadAsStringAsync().Result);
