using Grpc.Net.Client;
using GRPC.Server.Protos;

using (var service = GrpcChannel.ForAddress("https://localhost:7197/"))
{
    var client = new SumService.SumServiceClient(service);
    var req = new SumRequest
    {
        Num1 = 10,
        Num2 = 20
    };
    var result = client.Sum(req);
    Console.WriteLine(result.Result);
    Console.ReadKey();
}