using System.Linq;
using System.Threading.Tasks;
using Cosmcs.Client;
using Cardchain.Cardchain;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

namespace CardchainCs.CardchainClient
{
    public class CardchainClient
    {
        public EasyClient Ec { get; }
        public MsgClient CcTxClient { get; }
        public Cosmos.Authz.V1beta1.MsgClient AuthzTxClient { get; }
        public QueryClient QueryClient { get; }


        public CardchainClient(QueryClient queryClient, string chainId, byte[] bytes)
        {
            QueryClient = queryClient;
            Ec = new EasyClient(queryClient, chainId, bytes, "cc");
            CcTxClient = new MsgClient(Ec);
            AuthzTxClient = new Cosmos.Authz.V1beta1.MsgClient(Ec);
        }

        public Task<ClientResponse<MsgCardSchemeBuyResponse>> SendMsgBuyCardScheme(
            string bidAmout,
            string bidDenom)
        {
            return CcTxClient.SimulateAndSendMsgCardSchemeBuy(new MsgCardSchemeBuy
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
                    Value = new MsgMatchConfirm
                    {
                        Creator = creator,
                        MatchId = matchId,
                        Outcome = outcome,
                        VotedCards = { votedCards }
                    }.ToByteString(),
                    TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgConfirmMatch"
                }
            }, new MessageParser[] { MsgMatchConfirmResponse.Parser });
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
                        Value = new MsgCardVote
                        {
                            Creator = creator,
                            Vote = new SingleVote{
                                CardId = cardId,
                                VoteType = voteType,
                            }
                        }.ToByteString(),
                        TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgVoteCard"
                    }
                }, new MessageParser[] { MsgCardVoteResponse.Parser }
            );
        }

        public Task<ClientResponse<MsgMatchReportResponse>> SendMsgReportMatch(
            ulong matchId,
            ulong[] playedCardsA,
            ulong[] playedCardsB,
            Outcome outcome)
        {
            return CcTxClient.SimulateAndSendMsgMatchReport(new MsgMatchReport
            {
                Creator = Ec.AccoutAddress.ToString(),
                MatchId = matchId,
                Outcome = outcome,
                PlayedCardsA = { playedCardsA },
                PlayedCardsB = { playedCardsB }
            });
        }

        public Task<ClientResponse<MsgMatchOpenResponse>> SendMsgOpenMatch(
            ulong[] playerADeck,
            ulong[] playerBDeck,
            string playerA,
            string playerB)
        {
            return CcTxClient.SimulateAndSendMsgMatchOpen(new MsgMatchOpen
            {
                Creator = Ec.AccoutAddress.ToString(),
                PlayerA = playerA,
                PlayerB = playerB,
                PlayerADeck = { playerADeck },
                PlayerBDeck = { playerBDeck }
            });
        }

        public Task<ClientResponse<MsgSetCreateResponse>> SendMsgCreateSet(
            string name,
            string artist,
            string storyWriter,
            string[] contributors)
        {
            return CcTxClient.SimulateAndSendMsgSetCreate(new MsgSetCreate
            {
                Creator = Ec.AccoutAddress.ToString(),
                Name = name,
                Artist = artist,
                StoryWriter = storyWriter,
                Contributors = { contributors }
            });
        }

        public Task<ClientResponse<MsgEncounterDoResponse>> SendMsgEncounterDo(
            ulong encounterId, string user)
        {
            return CcTxClient.SimulateAndSendMsgEncounterDo(new MsgEncounterDo
            {
                Creator = Ec.AccoutAddress.ToString(),
                EncounterId = encounterId,
                User = user,
            });
        }

        public Task<ClientResponse<MsgEncounterCloseResponse>> SendMsgEncounterClose(
            ulong encounterId, string user, bool won)
        {
            return CcTxClient.SimulateAndSendMsgEncounterClose(new MsgEncounterClose
            {
                Creator = Ec.AccoutAddress.ToString(),
                EncounterId = encounterId,
                User = user,
                Won = won,
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
                        Value = new MsgBoosterPackBuy
                        {
                            Creator = creator,
                            SetId = setId,
                        }.ToByteString(),
                        TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgBuyBoosterPack"
                    }
                }, new MessageParser[] { MsgBoosterPackBuyResponse.Parser }
            );
        }

        public Task<SendMsgExecResponse> MultiSendMsgExecMsgBuyBoosterPack(
            string creator,
            ulong[] setIds)
        {
            return SendMsgExec(setIds.Select(id => new Any
            {
                Value = new MsgBoosterPackBuy
                {
                    Creator = creator,
                    SetId = id,
                }.ToByteString(),
                TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgBuyBoosterPack"
            }).ToArray(), setIds.Select<ulong, MessageParser>(_ => MsgBoosterPackBuyResponse.Parser).ToArray());
        }

        public Task<SendMsgExecResponse> SendMsgExecMsgOpenBoosterPack(
            string creator,
            ulong boosterPackId)
        {
            return SendMsgExec(new[]
                {
                    new Any
                    {
                        Value = new MsgBoosterPackOpen
                        {
                            Creator = creator,
                            BoosterPackId = boosterPackId
                        }.ToByteString(),
                        TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgOpenBoosterPack"
                    }
                }, new MessageParser[] { MsgBoosterPackOpenResponse.Parser }
            );
        }

        public Task<SendMsgExecResponse> MultiSendMsgExecMsgOpenBoosterPack(
            string creator,
            ulong[] boosterPackIds)
        {
            return SendMsgExec(boosterPackIds.Select(id => new Any
            {
                Value = new MsgBoosterPackOpen
                {
                    Creator = creator,
                    BoosterPackId = id
                }.ToByteString(),
                TypeUrl = "/DecentralCardGame.cardchain.cardchain.MsgOpenBoosterPack"
            }).ToArray(),
                boosterPackIds.Select<ulong, MessageParser>(_ => MsgBoosterPackOpenResponse.Parser).ToArray());
        }
    }
}
