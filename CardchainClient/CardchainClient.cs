using System.Linq;
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
        public MsgClient CcTxClient { get; }
        public Cosmos.Authz.V1beta1.MsgClient AuthzTxClient { get; }
        public Query.QueryClient CcQueryClient { get; }
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
            CcTxClient = new MsgClient(Ec);
            AuthzTxClient = new Cosmos.Authz.V1beta1.MsgClient(Ec);
            CcQueryClient = new Query.QueryClient(Ec.Channel);
            BankQueryClient = new Cosmos.Bank.V1beta1.Query.QueryClient(Ec.Channel);
            AuthzQueryClient = new Cosmos.Authz.V1beta1.Query.QueryClient(Ec.Channel);
            GovQueryClient = new Cosmos.Gov.V1beta1.Query.QueryClient(Ec.Channel);
            AuthQueryClient = Ec.AuthClient;
        }

        public Task<ClientResponse<MsgBuyCardSchemeResponse>> SendMsgBuyCardScheme(
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

        public Task<SendMsgExecResponse> SendMsgExec(Any[] msgs, MessageParser[] parsers)
        {
            return AuthzTxClient.SendMsgExec(new Cosmos.Authz.V1beta1.MsgExec
                {
                    Grantee = Ec.AccoutAddress.ToString(),
                    Msgs = { msgs }
                }
            ).ContinueWith(r => new SendMsgExecResponse(r.Result, parsers));
        }

        public Task<SendMsgExecResponse> SendMsgExecMsgConfirmMatch(
            string creator,
            ulong matchId,
            Outcome outcome,
            SingleVote[] votedCards)
        {
            return SendMsgExec(new[]
            {
                new Any
                {
                    Value = new MsgConfirmMatch
                    {
                        Creator = creator,
                        MatchId = matchId,
                        Outcome = outcome,
                        VotedCards = { votedCards }
                    }.ToByteString(),
                    TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgConfirmMatch"
                }
            }, new MessageParser[] { MsgConfirmMatchResponse.Parser });
        }

        public Task<SendMsgExecResponse> SendMsgExecMsgVoteCard(
            string creator,
            ulong cardId,
            string voteType)
        {
            return SendMsgExec(new[]
                {
                    new Any
                    {
                        Value = new MsgVoteCard
                        {
                            Creator = creator,
                            CardId = cardId,
                            VoteType = voteType,
                        }.ToByteString(),
                        TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgVoteCard"
                    }
                }, new MessageParser[] { MsgVoteCardResponse.Parser }
            );
        }

        public Task<ClientResponse<MsgReportMatchResponse>> SendMsgReportMatch(
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

        public Task<ClientResponse<MsgMsgOpenMatchResponse>> SendMsgOpenMatch(
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

        public Task<ClientResponse<MsgCreateCollectionResponse>> SendMsgCreateCollection(
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

        public Task<SendMsgExecResponse> SendMsgExecMsgBuyCollection(
            string creator,
            ulong collectionId)
        {
            return SendMsgExec(new[]
                {
                    new Any
                    {
                        Value = new MsgBuyCollection
                        {
                            Creator = creator,
                            CollectionId = collectionId,
                        }.ToByteString(),
                        TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgBuyCollection"
                    }
                }, new MessageParser[] { MsgBuyCollectionResponse.Parser }
            );
        }

        public Task<SendMsgExecResponse> MultiSendMsgExecMsgBuyCollection(
            string creator,
            ulong[] collectionIds)
        {
            return SendMsgExec(collectionIds.Select(id => new Any
            {
                Value = new MsgBuyCollection
                {
                    Creator = creator,
                    CollectionId = id,
                }.ToByteString(),
                TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgBuyCollection"
            }).ToArray(), collectionIds.Select<ulong, MessageParser>(_ => MsgBuyCollectionResponse.Parser).ToArray());
        }

        public Task<SendMsgExecResponse> SendMsgExecMsgOpenBoosterPack(
            string creator,
            ulong boosterPackId)
        {
            return SendMsgExec(new[]
                {
                    new Any
                    {
                        Value = new MsgOpenBoosterPack
                        {
                            Creator = creator,
                            BoosterPackId = boosterPackId
                        }.ToByteString(),
                        TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgOpenBoosterPack"
                    }
                }, new MessageParser[] { MsgOpenBoosterPackResponse.Parser }
            );
        }
    }
}