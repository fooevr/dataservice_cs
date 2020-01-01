using System;
using System.Collections;
using Google.Protobuf;
using System.Linq;
using Google.Protobuf.WellKnownTypes;
using com.variflight.dataservice.client;
using t = Com.Variflight.Dataservice.Test;
using d = Com.Variflight.Dataservice.Test.dao;
using Grpc.Core.Interceptors;

namespace testdataservice
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = new Grpc.Core.Channel("127.0.0.1:11180", Grpc.Core.ChannelCredentials.Insecure);
            var client = new Com.Variflight.Dataservice.Test.ScoreService.ScoreServiceClient(channel.Intercept(new Intersection()));
            var cancle = client.LoopCall(client.GetAllScoresAsync, new Empty(), (d.StudentScoresMap dao)=> { });
            Console.Read();
            Console.WriteLine("canceling");
            cancle.Cancel();
            Console.WriteLine("canceled");
            Console.Read();
        }

        static byte[] toBinary(string input)
        {
            input = input.Replace(" ", "");
            int numOfBytes = input.Length / 8;
            byte[] bytes = new byte[numOfBytes];
            for (int i = 0; i < numOfBytes; ++i)
            {
                bytes[i] = Convert.ToByte(input.Substring(8 * i, 8), 2);
            }
            return bytes;
        }
    }
}