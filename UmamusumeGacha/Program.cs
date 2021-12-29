using Microsoft.Data.Sqlite;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using Umamusume;
using Umamusume.Model;
using Umamusume.Model.Master;
using UmamusumeSave.Model;

namespace UmamusumeGacha
{
    class Program
    {
        private static int finish_count = 0;

        private static BlockingCollection<DBAccountNew> accounts = new ();

        private static readonly object loglock = new object();

        private static readonly SortedDictionary<int, string> cards = new(MasterContext.Instance
            .TextData.Where(c => c.Category == 75 && c.Index > 30000)
            .ToDictionary(c => (int)c.Index, c => c.Text));

        private static SqliteConnection conn;

        private static void SaveTo(UmamusumeClient client)
        {
            string pwd = Utils.GenRandomPassword(client.Account.ViewerId);
            client.RetryRequest(new ChangeNameRequest
            {
                name = new string(new char[] { 'i', 'n', 'i', 't', '2' })
            });
            client.PublishTransition(pwd);
            client.Account.extra.password = pwd;


            const string qstr = "insert into accounts (udid, authkey, password, cardnum, viewer_id, {0}) values (@udid, @authkey, @password, @cardnum, @viewer_id, {1})";

            SqliteCommand cmd = new SqliteCommand(string.Format(qstr, string.Join(",", cards.Select(s => s.Value).Select(s => s[1..s.IndexOf("]")]).Select(s => $"`{s}`")), string.Join(",", Enumerable.Range(1, cards.Count).Select(i => $"@c{i}"))), conn);
            cmd.Parameters.Add("udid", SqliteType.Text).Value = client.Account.Udid.ToString();
            cmd.Parameters.Add("authkey", SqliteType.Text).Value = client.Account.Authkey;
            cmd.Parameters.Add("password", SqliteType.Text).Value = client.Account.extra.password;
            int i = 0;
            foreach (var c in cards)
                cmd.Parameters.Add($"c{++i}", SqliteType.Integer).Value = client.Account.extra.support_cards.TryGetValue(c.Key, out int val) ? val : 0;
            cmd.Parameters.Add("cardnum", SqliteType.Integer).Value = client.Account.extra.support_cards.Count;
            cmd.Parameters.Add("viewer_id", SqliteType.Integer).Value = client.Account.ViewerId;
            lock (conn)
                cmd.ExecuteNonQuery();
            cmd.Dispose();

            /*
            AccountContext.context.Account.Add(new DBAccount
            {
                authkey = client.Account.Authkey,
                cardnum = client.Account.extra.support_cards.Count,
                cards = string.Join("<br/>", client.Account.extra.support_cards.Select(pair => $"[{cards[pair.Key]},{pair.Value}]")),
                password = client.Account.extra.password,
                udid = client.Account.Udid.ToString(),
                viewer_id = client.Account.ViewerId
            });
            */

            var invalid = client.Account.extra.support_cards.FirstOrDefault(p => !cards.ContainsKey(p.Key));
            if (invalid.Key > 30000)
            {
                Console.WriteLine($"{client.LogPrefix}未知的id{invalid.Key}，请尝试更新版本。");
            }
        }

        private static void Log(string message)
        {
            var now = DateTime.Now;
            var msg = $"{now}] {message}\n";
            lock (loglock) File.AppendAllText($"log-{now:MM-dd}.txt", msg);
        }

        private static int _gachaid = 0;
        private static readonly object gachaidlock = new object();
        private static int[] card_exchanges;

        private static bool IsExists(DBAccountNew acc)
        {
            using SqliteCommand cmd = new SqliteCommand("select * from accounts where viewer_id=" + acc.viewer_id, conn);
            using var reader = cmd.ExecuteReader();
            return reader.Read();
        }

        public static void RegisterOnce(UmamusumeClient client, DBAccountNew acc)
        {
            if (IsExists(acc)) return;

            try
            {
                client.ResetAccount();
                client.Account.Udid = Guid.Parse(acc.udid);
                client.Account.Authkey = acc.authkey;
                client.Account.ViewerId = acc.viewer_id;
                //client.Signup();
                //var client = new UmamusumeClient(JsonConvert.DeserializeObject<Account>(File.ReadAllText("account.json")));
                //File.WriteAllText("account.json", JsonConvert.SerializeObject(client.Account));

                client.StartSession();
                client.Login();
                int _gachaid;

                lock (gachaidlock)
                {
                    if (Program._gachaid == 0)
                    {
                        GachaInfoList[] gachas = client.RetryRequest(new GachaLoadRequest()).data.gacha_info_list;
                        Program._gachaid = gachas.Where(gachas => gachas.id / 10000 == 3).Select(gachas => gachas.id).Max();
                    }
                    _gachaid = Program._gachaid;
                }

                if (client.FCoin < 30000)
                {
                    throw new Exception($"账号 {client.Account.ViewerId} 钻石不足，无法抽卡");
                }

                var num = 0;

                for (int i = 0; i < 20; ++i)
                    num = client.Gacha(_gachaid);
                
                int count = client.Account.extra.support_cards.Sum(p => p.Value);
                Console.WriteLine($"{client.LogPrefix} gacha get = {count}");

                foreach (var card in card_exchanges)
                {
                    if (client.Account.extra.support_cards.TryGetValue(card, out var val) && val == 4)
                    {
                        client.RetryRequest(new GachaLimitExchangeRequest
                        {
                            card_id = card,
                            card_type = 2,
                            current_num = num,
                            gacha_id = _gachaid
                        });
                        if (!client.Account.extra.support_cards.ContainsKey(card))
                            client.Account.extra.support_cards[card] = 0;
                        ++client.Account.extra.support_cards[card];
                        goto exit;
                    }
                }
                foreach (var card in card_exchanges)
                {
                    if (client.Account.extra.support_cards.TryGetValue(card, out var val) && val > 4) continue;
                    client.RetryRequest(new GachaLimitExchangeRequest
                    {
                        card_id = card,
                        card_type = 2,
                        current_num = num,
                        gacha_id = _gachaid
                    });
                    if (!client.Account.extra.support_cards.ContainsKey(card))
                        client.Account.extra.support_cards[card] = 0;
                    ++client.Account.extra.support_cards[card];
                    break;
                }

                exit:
                SaveTo(client);

            }
            catch (Exception e)
            {
                Console.WriteLine($"{client.LogPrefix} {e}");
                Log($"{client.LogPrefix} {e}");
            }
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
                    var acc = accounts.Take();
                    RegisterOnce(client, acc);
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
            accounts = new BlockingCollection<DBAccountNew>();
            foreach (var acc in AccountNewContext.context.Account)
                accounts.Add(acc);
        }

        private static int speed;
        private static double req_speed;

        public static void Main(string[] args)
        {
            Console.Write("线程数:");
            var tcount = int.Parse(Console.ReadLine());
            Console.Write("兑换卡id,按优先级逗号分隔:");
            card_exchanges = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            conn = new SqliteConnection("data source=accounts.db");
            conn.Open();


            foreach (var prop in JsonConvert.DeserializeObject<Dictionary<int, string>>(File.ReadAllText("extra.json")))
            {
                cards[prop.Key] = prop.Value;
            }
            try
            {
                new SqliteCommand("create table if not exists accounts(" +
                                  "cardnum INTEGER," +
                                  string.Concat(cards.Select(s => s.Value).Select(s => s[1..s.IndexOf("]")]).Select(c => $"`{c}` INTEGER,")) +
                                  "viewer_id INTEGER," +
                                  "password TEXT," +
                                  "udid TEXT," +
                                  "authkey TEXT);", conn).ExecuteNonQuery();

                new SqliteCommand("create unique index id_index on accounts (viewer_id)", conn).ExecuteNonQuery();
            }
            catch
            {

            }

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
