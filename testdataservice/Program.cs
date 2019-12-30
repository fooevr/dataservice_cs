using System;
using System.Collections;
using Google.Protobuf;
using System.Linq;
using Google.Protobuf.WellKnownTypes;
using System.Collections.Generic;
using com.variflight.dataservice.client;
using Com.Variflight.Dataservice.Test;
using Grpc.Core.Interceptors;

namespace testdataservice
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = new Grpc.Core.Channel("127.0.0.1:11180", Grpc.Core.ChannelCredentials.Insecure);
            var client = new Com.Variflight.Dataservice.Test.ScoreService.ScoreServiceClient(channel.Intercept(new Intersection()));
            var cancle = client.LoopCall(client.GetAllScoresAsync, new Empty(), (dao)=> { });
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("canceling");
            cancle.Cancel();
            Console.WriteLine("canceled");
            Console.Read();
            var d = new Com.Variflight.Dataservice.Test.student
            {
                Age = 30,
                Comment = "张重阳123",
                Id = 1,
                Ivx = 123,
                S = new Com.Variflight.Dataservice.Test.student { Name = "呵呵？" },

            };
            d.Ms.Add("a", new Com.Variflight.Dataservice.Test.student { Age = 28 });
            d.Ri.Add(1);
            d.Ri.Add(2);
            var t = new Com.Variflight.Dataservice.Test.dao.student { };
            t.MergeFromMessage(d, true, null);



            var d2 = new Com.Variflight.Dataservice.Test.student
            {
                Age = 30,
                Comment = "张重阳123",
                Id = 1,
                Ivx = 123,
                S = new Com.Variflight.Dataservice.Test.student { Name = "呵呵？!!!" },

            };
            d2.Ms.Add("a", new Com.Variflight.Dataservice.Test.student { Age = 28 });
            d2.Ri.Add(1);
            d2.Ri.Add(2);
            var c = new com.variflight.dataservice.ChangeDesc
            {
                FieldTags = ByteString.CopyFrom(toBinary("00000000 00000000 10000000")),
                ChangeTags = ByteString.CopyFrom(toBinary("00000000 10000000 00000000"))
            };
            c.FieldsChangeDescs.Add(new com.variflight.dataservice.ChangeDesc {
                FieldTags = ByteString.CopyFrom(toBinary("00100000 00000000 00000000"))
            });
            t.MergeFromMessage(d2, false, c);
            Console.WriteLine(t);
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