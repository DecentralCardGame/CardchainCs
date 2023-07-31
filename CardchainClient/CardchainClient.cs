using System.Threading.Tasks;
using Cosmcs.Client;
using DecentralCardGame.Cardchain.Cardchain;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace CardchainCs.CardchainClient

{
    public class CardchainClient
    {
        public EasyClient Ec { get; }
        public DecentralCardGame.Cardchain.Cardchain.MsgClient CcModuleClient { get; }
        public Cosmos.Authz.V1beta1.MsgClient AuthzClient { get; }

        public CardchainClient(string baseUrl, string chainId, byte[] bytes)
        {
            var reg = TypeRegistry.FromFiles(
                Cosmos.Auth.V1beta1.QueryReflection.Descriptor,
                Cosmos.Crypto.Secp256k1.KeysReflection.Descriptor,
                TxReflection.Descriptor
            );
            Ec = new EasyClient(baseUrl, chainId, bytes, "cc", reg);
            CcModuleClient = new DecentralCardGame.Cardchain.Cardchain.MsgClient(Ec);
            AuthzClient = new Cosmos.Authz.V1beta1.MsgClient(Ec);
        }

        public Task<string> SendMsgBuyCardScheme(string bidAmout, string bidDenom)
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

        public Task<string> SendMsgExec(Any msg)
        {
            return AuthzClient.SendMsgExec(new Cosmos.Authz.V1beta1.MsgExec
                {
                    Grantee = Ec.AccoutAddress.ToString(),
                    Msgs = { msg }
                }
            );
        }

        public Task<string> SendMsgExecMsgConfirmMatch(ulong matchId, Outcome outcome)
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

        public Task<string> SendMsgExecMsgVoteCard(ulong cardId, string voteType)
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

        public Task<string> MsgReportMatch(string playerA, string playerB, ulong[] cardsA, ulong[] cardsB,
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