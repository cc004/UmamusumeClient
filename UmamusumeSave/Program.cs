using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.Data.Sqlite;
using Newtonsoft.Json;
using Umamusume;
using Umamusume.Model;
using UmamusumeSave.Model;

namespace UmamusumeSave
{
    class Program
    {
        private static int finish_count = 0;

        private static BlockingCollection<DBAccountOld> accounts = new BlockingCollection<DBAccountOld>();

        private static readonly object loglock = new object();

        private static void Log(string message)
        {
            var now = DateTime.Now;
            var msg = $"{now}] {message}\n";
            lock (loglock) File.AppendAllText($"log-{now:MM-dd}.txt", msg);
        }

        private static void FarmTask(int id)
        {
            UmamusumeClient client = new UmamusumeClient()
            {
                LogPrefix = $"[Thread #{id}]"
            };
            while (true)
            {
                try
                {
                    client.ResetAccount();
                    var acc = accounts.Take();
                    if (AccountNewContext.context.Account.Any(a => a.viewer_id == acc.viewer_id)) continue;
                    var pwd = client.RetryRequest(new DataLinkChainByTransitionCodeRequest()
                    {
                        input_viewer_id = acc.viewer_id,
                        password = Utils.Bin2Hex(Utils.MakeMd5(acc.password))
                    }).data;

                    client.Account.ViewerId = pwd.chained_viewer_id.Value;
                    client.Account.Authkey = pwd.auth_key;

                    lock (AccountNewContext.context)
                    {
                        AccountNewContext.context.Account.Add(new DBAccountNew()
                        {
                            viewer_id = client.Account.ViewerId,
                            authkey = client.Account.Authkey,
                            password = acc.password,
                            udid = client.Account.Udid.ToString()
                        });
                        AccountNewContext.context.SaveChanges();
                    }
                    Interlocked.Increment(ref finish_count);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        private static void Load()
        {
            accounts = new BlockingCollection<DBAccountOld>();
            foreach (var acc in AccountOldContext.context.Account)
                accounts.Add(acc);
            AccountNewContext.context.SaveChanges();
        }

        private static int speed;
        private static double req_speed;

        public static void Main(string[] args)
        {
            Console.Write("线程数:");
            var tcount = int.Parse(Console.ReadLine());

            ThreadPool.SetMaxThreads(1024, 1024);
            ThreadPool.SetMinThreads(256, 256);


            Load();
            var rnd = new Random();

            new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(10000);

                    var sb = new StringBuilder();
                    var count = accounts.Count;
                    sb.AppendLine($"[Watchdog] remaining jobs {count} for vid =");
                    sb.AppendLine($"[Watchdog] current speed {speed * 0.36:f1} wpt/h, {req_speed:f1} req/s");
                    if (speed != 0)
                    {
                        var timeneed = new TimeSpan(0, 0, count * 10 / speed);
                        sb.AppendLine($"[Watchdog] etc {timeneed}, finished in {DateTime.Now + timeneed}");
                    }
                    else
                        sb.AppendLine($"[Watchdog] etc --, finished in --");
                    Console.WriteLine(sb);
                }
            }).Start();


            for (int i = 0; i < tcount; ++i)
            {
                Thread.Sleep(rnd.Next(0, 1000));
                int j = i;
                new Thread(() => FarmTask(j)).Start();
            }

        }

    }

}
