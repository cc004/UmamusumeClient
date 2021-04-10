using MsgPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Umamusume.Model;
using Umamusume.Model.Master;

namespace Umamusume
{
    public class Program
    {
        private static readonly SortedDictionary<int, string> cards = new (MasterContext.Instance
            .TextData.Where(c => c.Category == 75 && c.Index > 30000)
            .ToDictionary(c => (int)c.Index, c => c.Text));

        private static void SaveTo(UmamusumeClient client)
        {
            string pwd = Utils.GenRandomPassword();
            client.RetryRequest(new ChangeNameRequest
            {
                name = "init"
            });
            client.PublishTransition(pwd);
            client.Account.extra.password = pwd;

            /*
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
            */


            AccountContext.context.Account.Add(new DBAccount
            {
                authkey = client.Account.Authkey,
                cardnum = client.Account.extra.support_cards.Count,
                cards = string.Join("<br/>", client.Account.extra.support_cards.Select(pair => $"[{cards[pair.Key]},{pair.Value}]")),
                password = client.Account.extra.password,
                udid = client.Account.Udid.ToString(),
                viewer_id = client.Account.ViewerId
            });

            AccountContext.context.SaveChanges();

            var invalid = client.Account.extra.support_cards.FirstOrDefault(p => !cards.ContainsKey(p.Key));
            if (invalid.Key > 30000)
            {
                Console.WriteLine($"{client.LogPrefix}未知的id{invalid.Key}，请尝试更新版本。");
            }
        }

        private static int _gachaid = 0;
        private static readonly object gachaidlock = new object();

        public static void RegisterOnce(UmamusumeClient client)
        {

            try
            {
                client.ResetAccount();
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
                    if (Program._gachaid == 0)
                    {
                        GachaInfoList[] gachas = client.RetryRequest(new GachaLoadRequest()).data.gacha_info_list;
                        Program._gachaid = gachas.Where(gachas => gachas.id / 10000 == 3).Select(gachas => gachas.id).Max();
                    }
                    _gachaid = Program._gachaid;
                }

                while (client.FCoin >= 1500)
                    client.Gacha(_gachaid);

                const int ssrticketId = 114;

                for (int i = presents.SingleOrDefault(i => i.item_id == ssrticketId)?.number ?? 0; i > 0; --i)
                    client.Gacha(20002, 1, ssrticketId, i);

                Console.WriteLine($"{client.LogPrefix} gacha get = {client.Account.extra.support_cards.Count}");
                int count = client.Account.extra.support_cards.Sum(p => p.Value);

                if (client.Account.extra.support_cards.TryGetValue(30028, out var val) && val > 2)
                    SaveTo(client);
                else
                {
                    client.RetryRequest(new FriendFollowRequest()
                    {
                        friend_viewer_id = 250278690
                    });
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"{client.LogPrefix} {e}");
            }
        }

        private static void RegisterTask(int id)
        {
            UmamusumeClient client = new UmamusumeClient(new SimpleLz4Frame(id))
            {
                LogPrefix = $"[Thread #{id}]"
            };
            while (true)
            {
                RegisterOnce(client);
            }
        }

        private static void Test()
        {
            UmamusumeClient client = new UmamusumeClient(new SimpleLz4Frame(0))
            {
                LogPrefix = string.Empty
            };
            /*
            client.Signup();

            File.WriteAllText("account.json", JsonConvert.SerializeObject(client.Account));
            client.StartSession();
            client.Login();
            client.Request(new TutorialSkipRequest());
            */
            //client.StartSession();
            var pwd = client.RetryRequest(new DataLinkChainByTransitionCodeRequest()
            {
                input_viewer_id = 934663949,
                password = Utils.Bin2Hex(Utils.MakeMd5("Aa123456"))
            }).data.auth_key;
            client.Account.ViewerId = 934663949;
            client.Account.Authkey = pwd;
            client.StartSession();
            client.Login();

        }

        private static void Main(string[] args)
        {
            //Test();
            ThreadPool.SetMaxThreads(512, 512);
            ThreadPool.SetMinThreads(128, 128);
            AccountContext.context.Database.EnsureCreated();

            /*
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

            */
            for (int i = 0; i < 64; ++i)
            {
                int j = i;
                new Thread(new ThreadStart(() => RegisterTask(j))).Start();
                Thread.Sleep(500);
            }
        }
    }
}
