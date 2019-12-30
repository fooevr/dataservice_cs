using System;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Core.Interceptors;

namespace com.variflight.dataservice.client
{
    public class Intersection : Grpc.Core.Interceptors.Interceptor
    {
        public Intersection()
        {
        }

        public override Task<TResponse> UnaryServerHandler<TRequest, TResponse>(TRequest request, ServerCallContext context, UnaryServerMethod<TRequest, TResponse> continuation)
        {
            return base.UnaryServerHandler(request, context, continuation);
        }

        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context, AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            var result = base.AsyncUnaryCall(request, context, continuation);
            var ctx = new ClientInterceptorContext<TRequest, TResponse>(context.Method, context.Host, context.Options);
            return result;
        }
    }
}
