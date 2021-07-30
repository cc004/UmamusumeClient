using Microsoft.Data.Sqlite;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Umamusume;
using Umamusume.Model;
using Umamusume.Model.Master;

namespace UmamusumeLogin
{
    class Program
    {
        private static int finish_count = 0;

        private static BlockingCollection<Account> accounts = new BlockingCollection<Account>();

        private static readonly object loglock = new object();

        private static void Log(string message)
        {
            var now = DateTime.Now;
            var msg = $"{now}] {message}\n";
            lock (loglock) File.AppendAllText($"log-{now:MM-dd}.txt", msg);
        }

        private static void FarmTask(int id)
        {
            UmamusumeClient client = new UmamusumeClient(new SimpleLz4Frame(id))
            {
                LogPrefix = $"[Thread #{id}]"
            };
            while (true)
            {
                try
                {
                    client.ResetAccount();
                    client.ChangeAccount(accounts.Take());
                    client.StartSession();
                    client.Login();
                    client.ReceivePresents();

                    Console.WriteLine($"[Thread #{id}] free coin = {client.FCoin}");
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
            var conn = new SqliteConnection("data source=accounts.db");
            conn.Open();

            accounts = new BlockingCollection<Account>();
            var cmd = new SqliteCommand("select viewer_id, udid, authkey from accounts", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                accounts.Add(new Account
                {
                    Authkey = reader.GetString(2),
                    Udid = Guid.Parse(reader.GetString(1)),
                    ViewerId = reader.GetInt64(0)
                });
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
