using System.Threading.Tasks;
using Cosmcs.Client;
using Cosmos.Authz.V1beta1;
using DecentralCardGame.Cardchain.Cardchain;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using TxReflection = DecentralCardGame.Cardchain.Cardchain.TxReflection;

namespace CardchainCs.CardchainClient
{
    public class CardchainClient
    {
        public EasyClient Ec { get; }
        public DecentralCardGame.Cardchain.Cardchain.MsgClient CcTxClient { get; }
        public Cosmos.Authz.V1beta1.MsgClient AuthzTxClient { get; }
        public DecentralCardGame.Cardchain.Cardchain.Query.QueryClient CcQueryClient { get; }
        public Cosmos.Auth.V1beta1.Query.QueryClient AuthQueryClient { get; }
        public Cosmos.Bank.V1beta1.Query.QueryClient BankQueryClient { get; }
        public Cosmos.Authz.V1beta1.Query.QueryClient AuthzQueryClient { get; }
        public Cosmos.Gov.V1beta1.Query.QueryClient GovQueryClient { get; }

        public CardchainClient(string rpcUrl, string chainId, byte[] bytes, EasyClientOptions? options = null)
        {
            var reg = TypeRegistry.FromFiles(
                Cosmos.Auth.V1beta1.QueryReflection.Descriptor,
                Cosmos.Crypto.Secp256k1.KeysReflection.Descriptor,
                TxReflection.Descriptor
            );
            Ec = new EasyClient(rpcUrl, chainId, bytes, "cc", reg, options);
            CcTxClient = new DecentralCardGame.Cardchain.Cardchain.MsgClient(Ec);
            AuthzTxClient = new Cosmos.Authz.V1beta1.MsgClient(Ec);
            CcQueryClient = new DecentralCardGame.Cardchain.Cardchain.Query.QueryClient(Ec.Channel);
            BankQueryClient = new Cosmos.Bank.V1beta1.Query.QueryClient(Ec.Channel);
            AuthzQueryClient = new Cosmos.Authz.V1beta1.Query.QueryClient(Ec.Channel);
            GovQueryClient = new Cosmos.Gov.V1beta1.Query.QueryClient(Ec.Channel);
            AuthQueryClient = Ec.AuthClient;
        }

        public Task<Cosmcs.Client.ClientResponse<MsgBuyCardSchemeResponse>> SendMsgBuyCardScheme(
            string bidAmout,
            string bidDenom)
        {
            return CcTxClient.SendMsgBuyCardScheme(new MsgBuyCardScheme
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
            return AuthzTxClient.SendMsgExec(new Cosmos.Authz.V1beta1.MsgExec
                {
                    Grantee = Ec.AccoutAddress.ToString(),
                    Msgs = { msg }
                }
            );
        }

        public Task<Cosmcs.Client.ClientResponse<MsgExecResponse>> SendMsgExecMsgConfirmMatch(
            ulong matchId,
            Outcome outcome)
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

        public Task<Cosmcs.Client.ClientResponse<MsgReportMatchResponse>> SendMsgReportMatch(
            ulong matchId,
            ulong[] playedCardsA,
            ulong[] playedCardsB,
            Outcome outcome)
        {
            return CcTxClient.SendMsgReportMatch(new MsgReportMatch
            {
                Creator = Ec.AccoutAddress.ToString(),
                MatchId = matchId,
                Outcome = outcome,
                PlayedCardsA = { playedCardsA },
                PlayedCardsB = { playedCardsB }
            });
        }

        public Task<Cosmcs.Client.ClientResponse<MsgMsgOpenMatchResponse>> SendMsgOpenMatch(
            ulong matchId,
            ulong[] playerADeck,
            ulong[] playerBDeck,
            string playerA,
            string playerB,
            Outcome outcome)
        {
            return CcTxClient.SendMsgMsgOpenMatch(new MsgMsgOpenMatch
            {
                Creator = Ec.AccoutAddress.ToString(),
                PlayerA = playerA,
                PlayerB = playerB,
                PlayerADeck = { playerADeck },
                PlayerBDeck = { playerBDeck }
            });
        }

        public Task<Cosmcs.Client.ClientResponse<MsgCreateCollectionResponse>> SendMsgCreateCollection(
            string name,
            string artist,
            string storyWriter,
            string[] contributors)
        {
            return CcTxClient.SendMsgCreateCollection(new MsgCreateCollection
            {
                Creator = Ec.AccoutAddress.ToString(),
                Name = name,
                Artist = artist,
                StoryWriter = storyWriter,
                Contributors = { contributors }
            });
        }

        public Task<Cosmcs.Client.ClientResponse<MsgExecResponse>> SendMsgExecMsgBuyCollection(
            ulong collectionId)
        {
            var msg = new MsgBuyCollection
            {
                Creator = Ec.AccoutAddress.ToString(),
                CollectionId = collectionId,
            };

            return SendMsgExec(new Any
                {
                    Value = msg.ToByteString(),
                    TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgBuyCollection"
                }
            );
        }

        public Task<Cosmcs.Client.ClientResponse<MsgExecResponse>> SendMsgExecMsgOpenBoosterPack(
            ulong boosterPackId)
        {
            var msg = new MsgOpenBoosterPack
            {
                Creator = Ec.AccoutAddress.ToString(),
                BoosterPackId = boosterPackId
            };

            return SendMsgExec(new Any
                {
                    Value = msg.ToByteString(),
                    TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgOpenBoosterPack"
                }
            );
        }
    }
}