using System.Threading.Tasks;
using Cosmcs.Client;
using Cosmos.Authz.V1beta1;
using DecentralCardGame.Cardchain.Cardchain;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.Logging;
using TxReflection = DecentralCardGame.Cardchain.Cardchain.TxReflection;

namespace CardchainCs.CardchainClient

{
    public class CardchainClient
    {
        public EasyClient Ec { get; }
        public DecentralCardGame.Cardchain.Cardchain.MsgClient CcModuleClient { get; }
        public Cosmos.Authz.V1beta1.MsgClient AuthzClient { get; }

        public CardchainClient(string baseUrl, string rpcUrl, string chainId, byte[] bytes)
        {
            var reg = TypeRegistry.FromFiles(
                Cosmos.Auth.V1beta1.QueryReflection.Descriptor,
                Cosmos.Crypto.Secp256k1.KeysReflection.Descriptor,
                TxReflection.Descriptor
            );
            Ec = new EasyClient(baseUrl, rpcUrl, chainId, bytes, "cc", reg);
            CcModuleClient = new DecentralCardGame.Cardchain.Cardchain.MsgClient(Ec);
            AuthzClient = new Cosmos.Authz.V1beta1.MsgClient(Ec);
        }

        public Task<Cosmcs.Client.ClientResponse<MsgBuyCardSchemeResponse>> SendMsgBuyCardScheme(string bidAmout, string bidDenom)
        {
            return CcModuleClient.SendMsgBuyCardScheme(new MsgBuyCardScheme
                {
                    Creator = Ec.AccoutAddress.ToString(),
                    Bid = new Cosmos.Base.V1beta1.Coin
                    {
                        Amount = bidAmout,
                        Denom = bidDenom
                    }
                }
            );
        }

        public Task<Cosmcs.Client.ClientResponse<MsgExecResponse>> SendMsgExec(Any msg)
        {
            return AuthzClient.SendMsgExec(new Cosmos.Authz.V1beta1.MsgExec
                {
                    Grantee = Ec.AccoutAddress.ToString(),
                    Msgs = { msg }
                }
            );
        }

        public Task<Cosmcs.Client.ClientResponse<MsgExecResponse>> SendMsgExecMsgConfirmMatch(ulong matchId, Outcome outcome)
        {
            return SendMsgExec(new Any
                {
                    Value = new MsgConfirmMatch
                    {
                        Creator = Ec.AccoutAddress.ToString(),
                        MatchId = matchId,
                        Outcome = outcome,
                    }.ToByteString(),
                    TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgConfirmMatch"
                }
            );
        }

        public Task<Cosmcs.Client.ClientResponse<MsgExecResponse>> SendMsgExecMsgVoteCard(ulong cardId, string voteType)
        {
            var msg = new MsgVoteCard
            {
                Creator = Ec.AccoutAddress.ToString(),
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

        public Task<Cosmcs.Client.ClientResponse<MsgReportMatchResponse>> MsgReportMatch(string playerA, string playerB, ulong[] cardsA, ulong[] cardsB,
            Outcome outcome)
        {
            var msg = new MsgReportMatch
            {
                Creator = Ec.AccoutAddress.ToString(),
                PlayerA = playerA,
                PlayerB = playerB,
                Outcome = outcome,
            };
            msg.CardsA.AddRange(cardsA);
            msg.CardsB.AddRange(cardsB);

            return CcModuleClient.SendMsgReportMatch(msg);
        }
    }
}