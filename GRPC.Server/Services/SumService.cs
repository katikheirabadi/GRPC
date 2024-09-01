using Grpc.Core;
using GRPC.Server.Protos;

namespace GRPC.Server.Services
{
    public class SumService : GRPC.Server.Protos.SumService.SumServiceBase
    {
        public override Task<SumResponce> Sum(SumRequest request, ServerCallContext context)
        {
           var sumResult = request.Num1 + request.Num2;
            var result = new SumResponce()
            {
                Result = sumResult,
            };
            return Task.FromResult(result);
        }
    }
}
