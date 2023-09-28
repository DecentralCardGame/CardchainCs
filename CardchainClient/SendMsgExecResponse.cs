using System;
using System.Collections.Generic;
using Cosmcs.Client;
using Cosmos.Authz.V1beta1;
using Google.Protobuf;

namespace CardchainCs.CardchainClient {

    public class SendMsgExecResponse
    {
        public ClientResponse<MsgExecResponse> ClientResponse;
        public List<IMessage> ResponseMessages;

        public SendMsgExecResponse(ClientResponse<MsgExecResponse> value, MessageParser[] parsers)
        {
            ClientResponse = value;
            ResponseMessages = new List<IMessage>();
            
            if (parsers.Length != value.ResponseMessage!.Results.Count)
            {
                throw new Exception($"parsers ({parsers.Length}) has to be same length as Results ({value.ResponseMessage!.Results.Count})");
            }
            
            for (int i = 0; i < parsers.Length; i++)
            {
                ResponseMessages.Add(parsers[i].ParseFrom(value.ResponseMessage!.Results[i]));
            }
        }
    }
}