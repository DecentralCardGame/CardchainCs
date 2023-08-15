cd ./cardchain/proto

buf generate --template ../../buf.gen.yaml

cd ../../
rm ./Clients/TxGrpc.cs