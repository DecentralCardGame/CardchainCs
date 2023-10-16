rm -rf ./Buf ./Clients
cd ./cardchain/proto

buf generate --template ../../buf.gen.yaml
paths=$(find | grep -E "/query.proto|/service.proto")
echo $paths
for path in $paths; do
    p="../../Buf$(python -c "print('/'.join(i.capitalize() for i in \"$(echo $path | sed "s/query.proto//g" | sed "s/service.proto//g" | sed 's/\.//g')\".split('/')))")"
    buf generate --template ../../buf.gen.grpc.yaml -o $p $path
    echo $p
done