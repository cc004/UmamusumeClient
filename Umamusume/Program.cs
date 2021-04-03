using MsgPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Umamusume.Model;
using Umamusume.Model.Master;

namespace Umamusume
{
    internal class Program
    {
        private static SQLiteConnection conn;
        private static SQLiteConnection conn2;
        private static readonly SortedDictionary<int, string> cards = new SortedDictionary<int, string>(MasterContext.Instance
            .TextData.Where(c => c.Category == 75 && c.Index > 30000)
            .ToDictionary(c => (int)c.Index, c => c.Text));

        private static void SaveTo(UmamusumeClient client, SQLiteConnection conn)
        {
            string pwd = Utils.GenRandomPassword();
            client.RetryRequest(new ChangeNameRequest
            {
                name = "init"
            });
            client.PublishTransition(pwd);
            client.Account.extra.password = pwd;
            const string qstr = "insert into accounts (udid, authkey, password, cardnum, viewer_id, {0}) values (@udid, @authkey, @password, @cardnum, @viewer_id, {1})";

            SQLiteCommand cmd = new SQLiteCommand(string.Format(qstr, string.Join(",", cards.Select(s => s.Value).Select(s => s[1..s.IndexOf("]")]).Select(s => $"`{s}`")), string.Join(",", Enumerable.Range(1, cards.Count).Select(i => $"@c{i}"))), conn);
            cmd.Parameters.Add("udid", DbType.String).Value = client.Account.Udid.ToString();
            cmd.Parameters.Add("authkey", DbType.String).Value = client.Account.Authkey;
            cmd.Parameters.Add("password", DbType.String).Value = client.Account.extra.password;
            int i = 0;
            foreach (var c in cards)
                cmd.Parameters.Add($"c{++i}", DbType.Int32).Value = client.Account.extra.support_cards.TryGetValue(c.Key, out int val) ? val : 0;
            cmd.Parameters.Add("cardnum", DbType.Int32).Value = client.Account.extra.support_cards.Count;
            cmd.Parameters.Add("viewer_id", DbType.Int32).Value = client.Account.ViewerId;
            lock (conn)
                cmd.ExecuteNonQuery();

            var invalid = client.Account.extra.support_cards.FirstOrDefault(p => !cards.ContainsKey(p.Key));
            if (invalid.Key > 30000)
            {
                Console.WriteLine($"{client.LogPrefix}未知的id{invalid.Key}，请尝试更新版本。");
            }
        }

        private static int gachaid = 0;
        private static readonly object gachaidlock = new object();
        private static void RegisterTask(int id)
        {
            UmamusumeClient client = new UmamusumeClient(new SimpleLz4Frame(id))
            {
                LogPrefix = $"[Thread #{id}]"
            };
            while (true)
            {
                try
                {
                    client.Signup();
                    //var client = new UmamusumeClient(JsonConvert.DeserializeObject<Account>(File.ReadAllText("account.json")));
                    //File.WriteAllText("account.json", JsonConvert.SerializeObject(client.Account));
                    client.StartSession();
                    client.Login();
                    client.RetryRequest(new TutorialSkipRequest());

                    client.StartSession();
                    client.Login();
                    var presents = client.ReceivePresents().reward_summary_info.add_item_list;
                    int _gachaid;

                    lock (gachaidlock)
                    {
                        if (gachaid == 0)
                        {
                            GachaInfoList[] gachas = client.RetryRequest(new GachaLoadRequest()).data.gacha_info_list;
                            gachaid = gachas.Where(gachas => gachas.id / 10000 == 3).Select(gachas => gachas.id).Max();
                        }
                        _gachaid = gachaid;
                    }

                    while (client.FCoin >= 1500)
                        client.Gacha(_gachaid);

                    const int ssrticket_id = 114;

                    for (int i = presents.SingleOrDefault(i => i.item_id == ssrticket_id)?.number ?? 0; i >0; --i)
                        client.Gacha(20002, 1, ssrticket_id, i);

                    Console.WriteLine($"[Thread #{id}] gacha get = {client.Account.extra.support_cards.Count}");
                    int count = client.Account.extra.support_cards.Sum(p => p.Value);

                    if (client.Account.extra.support_cards.Count > 5)
                    {
                        SaveTo(client, conn);
                    }
                    else if (client.Account.extra.support_cards.Count == 5)
                    {
                        SaveTo(client, conn2);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"[Thread #{id}] {e}");
                }
                client.ResetAccount();
            }
        }

        private static void Test()
        {
            UmamusumeClient client = new UmamusumeClient(JsonConvert.DeserializeObject<Account>(File.ReadAllText("account.json")), new SimpleLz4Frame(0))
            {
                LogPrefix = ""
            };
            /*
            client.Signup();

            File.WriteAllText("account.json", JsonConvert.SerializeObject(client.Account));
            client.StartSession();
            client.Login();
            client.Request(new TutorialSkipRequest());
            */
            client.StartSession();
            client.Login();
        }

        private static void Main(string[] args)
        {
            //Test();
            ThreadPool.SetMaxThreads(512, 512);
            ThreadPool.SetMinThreads(128, 128);
            conn = new SQLiteConnection("data source=accounts.db");
            conn.Open();
            conn2 = new SQLiteConnection("data source=accounts2.db");
            conn2.Open();

            try
            {
                new SQLiteCommand("create table if not exists accounts(" +
                    "cardnum INTEGER," +
                    string.Concat(cards.Select(s => s.Value).Select(s => s[1..s.IndexOf("]")]).Select(c => $"`{c}` INTEGER,")) +
                    "viewer_id INTEGER," +
                    "password TEXT," +
                    "udid TEXT," +
                    "authkey TEXT);", conn).ExecuteNonQuery();

                new SQLiteCommand("create unique index id_index on accounts (viewer_id)", conn).ExecuteNonQuery();
            }
            catch
            {

            }

            try
            {
                new SQLiteCommand("create table if not exists accounts(" +
                    "cardnum INTEGER," +
                    string.Concat(cards.Select(s => s.Value).Select(s => s[1..s.IndexOf("]")]).Select(c => $"`{c}` INTEGER,")) +
                    "viewer_id INTEGER," +
                    "password TEXT," +
                    "udid TEXT," +
                    "authkey TEXT);", conn2).ExecuteNonQuery();

                new SQLiteCommand("create unique index id_index on accounts (viewer_id)", conn2).ExecuteNonQuery();
            }
            catch
            {

            }

            for (int i = 0; i < 64; ++i)
            {
                int j = i;
                new Thread(new ThreadStart(() => RegisterTask(j))).Start();
                Thread.Sleep(500);
            }
        }
    }
}
