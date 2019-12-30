using System;
using System.Threading.Tasks;
using Google.Protobuf;
using Grpc.Core;
using Grpc.Core.Interceptors;

namespace com.variflight.dataservice.client
{
    public static class Extensions
    {
        public static System.Threading.CancellationTokenSource LoopCall<P, R>(this ClientBase c, Func<P, Metadata, DateTime?,
            System.Threading.CancellationToken, AsyncUnaryCall<R>> func,
            P parameter,
            Action<R> updateDAO,
            System.Threading.CancellationTokenSource cancelTokenSource = null) where R : IMessage
        {
            if (cancelTokenSource == null)
            {
                cancelTokenSource = new System.Threading.CancellationTokenSource();
            }
            Task.Run(() =>
            {
                while (!cancelTokenSource.Token.IsCancellationRequested)
                {
                    var meta = new Metadata();
                    meta.Add("ts", "123456789");
                    AsyncUnaryCall<R> resp = func.Invoke(parameter, meta, null, cancelTokenSource.Token);
                    var md = resp.ResponseHeadersAsync.Result;
                    R result = resp.ResponseAsync.Result;
                    Console.WriteLine(result.ToString());
                }
            });
            return cancelTokenSource;
        }
    }
}
