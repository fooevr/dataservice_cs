using System;
using System.Threading.Tasks;
using Google.Protobuf;
using Grpc.Core;
using Grpc.Core.Interceptors;
using System.Linq;
using Newtonsoft.Json;
using Serilog.Core;
using Serilog;

namespace com.variflight.dataservice.client
{
    public static class Extensions
    {
        static Logger log = new LoggerConfiguration()
                .WriteTo.Console()
                .MinimumLevel.Debug()
                .CreateLogger();

        public static System.Threading.CancellationTokenSource LoopCall<P, R, D>(this ClientBase c, Func<P, Metadata, DateTime?,
            System.Threading.CancellationToken, AsyncUnaryCall<R>> func,
            P parameter,
            Action<D> updateDAOAction,
            System.Threading.CancellationTokenSource cancelTokenSource = null,
            D defaultDao = null,
            Int64 defaultTs = 0,
            int interval = 3000,
            Action<Exception> exAction = null) where R : class, IMessage where D : class, DAO
        {
            if (cancelTokenSource == null)
            {
                cancelTokenSource = new System.Threading.CancellationTokenSource();
            }
            Task.Run(async () =>
            {
                D dao = defaultDao;
                Int64 ts = defaultTs;
                //var count = 0;
                var start = DateTime.Now;
                while (!cancelTokenSource.Token.IsCancellationRequested)
                {
                    //count++;
                    //if(count % 1000 == 0)
                    //{
                    //    Console.WriteLine((DateTime.Now.Subtract(start).TotalMilliseconds) / count);
                    //}
                    if (dao == null)
                    {
                        dao = Activator.CreateInstance<D>();
                    }                    
                    try
                    {
                        Console.Clear();
                        var meta = new Metadata();
                        meta.Add("ts", ts.ToString());
                        AsyncUnaryCall<R> resp = func.Invoke(parameter, meta, null, cancelTokenSource.Token);
                        R result = resp.ResponseAsync.Result;
                        Metadata respMd = resp.ResponseHeadersAsync.Result;
                        if (resp.GetStatus().StatusCode!= StatusCode.OK)
                        {
                            var rsEntry = respMd.FirstOrDefault(p => p.Key.Equals("rs", StringComparison.CurrentCultureIgnoreCase));
                            if (rsEntry != null)
                            {
                                if (exAction != null)
                                {
                                    var ex = new Exception(rsEntry.Value);
                                    exAction(ex);
                                    throw ex;
                                }
                            }
                        }
                        var ctEntry = respMd.FirstOrDefault(p => p.Key.Equals("ct-bin", StringComparison.CurrentCultureIgnoreCase));
                        // unchange
                        if (ctEntry == null)
                        {
                            await Task.Delay(interval);
                            continue;
                        }
                        var cdEntry = respMd.FirstOrDefault(p => p.Key.Equals("cd-bin", StringComparison.CurrentCultureIgnoreCase));
                        var tsEntry = respMd.FirstOrDefault(p => p.Key.Equals("ts", StringComparison.CurrentCultureIgnoreCase));
                        if(tsEntry == null)
                        {
                            var ex = new Exception("miss ts field in response header.");
                            exAction(ex);
                            throw ex;
                        }
                        if (!Int64.TryParse(tsEntry.Value, out ts))
                        {
                            var ex = new Exception("parse ts to int64 failed.");
                            exAction(ex);
                            throw ex;
                        }
                        ChangeDesc cd = null;
                        if(cdEntry != null)
                        {
                            cd = new ChangeDesc();
                            cd.MergeFrom(cdEntry.ValueBytes);
                        }
                        if(result == null)
                        {
                            dao = null;
                            updateDAOAction(dao);
                        }
                        else
                        {
                            if (ctEntry.ValueBytes[0] == (byte)ChangeType.Created)
                            {
                                log.Debug("Create Change");
                                dao = Activator.CreateInstance<D>();
                                dao.MergeFromMessage(result, true, cd);
                                updateDAOAction(dao);
                            }
                            else if (ctEntry.ValueBytes[0] == (byte)ChangeType.Updated)
                            {
                                log.Debug("Update Change");
                                dao.MergeFromMessage(result, false, cd);
                            }
                            else if (ctEntry.ValueBytes[0] == (byte)ChangeType.Deleted)
                            {
                                log.Debug("Delete Change");
                                dao = null;
                                updateDAOAction(null);
                            }
                        }
                        if (cd != null)
                        {
                            Console.WriteLine(cd.ToString() + ": " + cd.ToByteArray().Length);
                        }
                        else
                        {
                            Console.WriteLine(result.ToString());
                        }
                        Console.WriteLine(JsonConvert.SerializeObject(dao, Formatting.Indented));
                    }
                    catch (Exception ex)
                    {
                        if(exAction != null)
                        {
                            exAction(ex);
                        }
                        Console.WriteLine(ex);
                    }
                    finally
                    {
                        await Task.Delay(interval);
                    }
                }
            });
            return cancelTokenSource;
        }
    }
}
