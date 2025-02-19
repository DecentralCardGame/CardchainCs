buf generate --template buf.gen.yaml

rm $(find Buf | grep "TxGrpc.pb.cs")
