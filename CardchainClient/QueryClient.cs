using Grpc.Net.Client;


namespace CardchainCs.CardchainClient
{
    public class QueryClient : Cosmcs.Client.QueryClient
    {
        public Cardchain.Cardchain.Query.QueryClient CcQueryClient { get; }
        public QueryClient(string rpcUrl, GrpcChannelOptions? options = null) : base(rpcUrl, options)
        {
            CcQueryClient = new Cardchain.Cardchain.Query.QueryClient(Channel);
        }
    }

}
