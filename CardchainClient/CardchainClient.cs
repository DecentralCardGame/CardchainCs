using System.Linq;
using System.Threading.Tasks;
using Cosmcs.Client;
using DecentralCardGame.Cardchain.Cardchain;
using Google.Protobuf;
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
            Ec = new EasyClient(rpcUrl, chainId, bytes, "cc", options);
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
            return CcTxClient.SimulateAndSendMsgBuyCardScheme(new MsgBuyCardScheme
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
            return AuthzTxClient.SimulateAndSendMsgExec(new Cosmos.Authz.V1beta1.MsgExec
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
            VoteType voteType)
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
            return CcTxClient.SimulateAndSendMsgReportMatch(new MsgReportMatch
            {
                Creator = Ec.AccoutAddress.ToString(),
                MatchId = matchId,
                Outcome = outcome,
                PlayedCardsA = { playedCardsA },
                PlayedCardsB = { playedCardsB }
            });
        }

        public Task<ClientResponse<MsgOpenMatchResponse>> SendMsgOpenMatch(
            ulong[] playerADeck,
            ulong[] playerBDeck,
            string playerA,
            string playerB)
        {
            return CcTxClient.SimulateAndSendMsgOpenMatch(new MsgOpenMatch
            {
                Creator = Ec.AccoutAddress.ToString(),
                PlayerA = playerA,
                PlayerB = playerB,
                PlayerADeck = { playerADeck },
                PlayerBDeck = { playerBDeck }
            });
        }

        public Task<ClientResponse<MsgCreateSetResponse>> SendMsgCreateSet(
            string name,
            string artist,
            string storyWriter,
            string[] contributors)
        {
            return CcTxClient.SimulateAndSendMsgCreateSet(new MsgCreateSet
            {
                Creator = Ec.AccoutAddress.ToString(),
                Name = name,
                Artist = artist,
                StoryWriter = storyWriter,
                Contributors = { contributors }
            });
        }

        public Task<SendMsgExecResponse> SendMsgExecMsgBuyBoosterPack(
            string creator,
            ulong setId)
        {
            return SendMsgExec(new[]
                {
                    new Any
                    {
                        Value = new MsgBuyBoosterPack
                        {
                            Creator = creator,
                            SetId = setId,
                        }.ToByteString(),
                        TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgBuyBoosterPack"
                    }
                }, new MessageParser[] { MsgBuyBoosterPackResponse.Parser }
            );
        }

        public Task<SendMsgExecResponse> MultiSendMsgExecMsgBuyBoosterPack(
            string creator,
            ulong[] setIds)
        {
            return SendMsgExec(setIds.Select(id => new Any
            {
                Value = new MsgBuyBoosterPack
                {
                    Creator = creator,
                    SetId = id,
                }.ToByteString(),
                TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgBuyBoosterPack"
            }).ToArray(), setIds.Select<ulong, MessageParser>(_ => MsgBuyBoosterPackResponse.Parser).ToArray());
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

        public Task<SendMsgExecResponse> MultiSendMsgExecMsgOpenBoosterPack(
            string creator,
            ulong[] boosterPackIds)
        {
            return SendMsgExec(boosterPackIds.Select(id => new Any
                {
                    Value = new MsgOpenBoosterPack
                    {
                        Creator = creator,
                        BoosterPackId = id
                    }.ToByteString(),
                    TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgOpenBoosterPack"
                }).ToArray(),
                boosterPackIds.Select<ulong, MessageParser>(_ => MsgOpenBoosterPackResponse.Parser).ToArray());
        }
    }
}