using Microsoft.Data.Sqlite;
using MsgPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Umamusume.Model;
using Umamusume.Model.Master;

namespace Umamusume
{
    public class Program
    {
        private static readonly SortedDictionary<int, string> cards = new (MasterContext.Instance
            .TextData.Where(c => c.Category == 75 && c.Index > 30000)
            .ToDictionary(c => (int)c.Index, c => c.Text));

        private static SqliteConnection conn;

        private static void SaveTo(UmamusumeClient client)
        {
            string pwd = Utils.GenRandomPassword(client.Account.ViewerId);
            client.RetryRequest(new ChangeNameRequest
            {
                name = "init2"
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

                int count = client.Account.extra.support_cards.Sum(p => p.Value);
                Console.WriteLine($"{client.LogPrefix} gacha get = {count}");

                if (count > 4)
                    SaveTo(client);

            }
            catch (Exception e)
            {
                Console.WriteLine($"{client.LogPrefix} {e}");
            }
        }

        private static void RegisterTask(int id)
        {
            UmamusumeClient client = new ()
            {
                LogPrefix = $"[Thread #{id}]",
            };
            while (true)
            {
                RegisterOnce(client);
            }
        }

        private static void Test()
        {
            var client = new UmamusumeClient();
            //client.Signup();
            /*
            BumaClient client = new BumaClient("1.2.11", new HttpClient(new HttpClientHandler()
            {
                UseProxy = true,
                Proxy = new WebProxy("127.0.0.1:8889")
            }));
            client.Signup();
            */
            
            var header = Convert.FromBase64String(UmamusumeClient.header);
            var encrypted = Convert.FromBase64String(
                "QAAAAFOaOU0So2wLis3G+w3MxrFfC98NAuhCNxUu7cTUOLIvAt4K/VaRjyDr/JRkXH2g/c7h9wpfSWpdeaeiDdve60nWrcj3xofFC9LVBKDoz2aHOVsXk5aLUynxpbVkymNZpW66qdG4N4t2prcfInZva6b5WpHML+Q8uZSS8ETmfKBVz5pIlE9ydcJspbPxWdZB+gLGmgb1xXCg1szQNvn1fJ03LmH/joMvcjxeHkxUIntTdgfYl9rwA+UU8fy3XqRdH158qy5+selRg1P8XEb5X4iDSjRqtmjxjSLgbbApVrT3zFic54i9fmy/9jwKC6qh8lUfvgD+ROgCf2mQu6PDmCjWMjtogfLI9S7IZ6rNcsRIpueti1rrWu1LmDMraWoRIivjwJ28Ip5eR9Ekt/rqnLd8LB/U68qpbxNdkeUywBgXKY0Uyv+IPTXUEwD05nXIoGG9ydbuLbwBd7T7TalYFV+UGKHevqwaLD2Jm2MSgMTWOpkTYOrEejLvq80uI5AsCkKgEd99aysiaYDeOoFGv2sTlXK4ItB7Ryijgyq2jHIRhAvDA9giNy/75GZe+Z2LTcb4NA701ZtWHuJ0pJp7EIGKpqHbnJNXrpedezM8Irf/ut4/cYUz7hc9rOxpx32ICVLQc3v8ixm1GRczWbDmE6cnowScCSwBWYtDvRLqVS2b6gG3n0d7XJtlX/IuiGizOG5PK1AW+2ErTkTQ2fDUj/0=");
            
            for (int i = 0; i < 32; ++i)
            {
                encrypted[i + 4] ^= header[i];
                encrypted[i + 4] ^= encrypted[i + 36];
            }
            
            var sid = encrypted[4..20];
            var udid = encrypted[20..36];

            //client.Account.Udid = Utils.ParseHex(udid);

            //client.RetryRequest(new ToolPreSignupRequest());
            byte[] key, iv;

            var temp = udid.Concat(header.TakeLast(20)).ToArray();
            using (var md5 = MD5.Create("MD5"))
            {
                md5.TransformFinalBlock(temp, 0, temp.Length);
                iv = md5.Hash;
            }

            temp = sid.Concat(header.TakeLast(20)).ToArray();
            using (var md5 = MD5.Create("MD5"))
            {
                md5.TransformFinalBlock(temp, 0, temp.Length);
                key = md5.Hash;
            }
            byte[] decryptedContent;
            var content = encrypted[68..];
            var aes = new RijndaelManaged();
            aes.BlockSize = 128;
            aes.Key = key;
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            using (var ms = new MemoryStream())
            {
                var encryptor = aes.CreateDecryptor(key, iv);

                using var stream = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
                stream.Write(content, 0, content.Length);
                stream.FlushFinalBlock();
                decryptedContent = ms.ToArray();
            }

            Console.WriteLine(Utils.Unpack(decryptedContent));


            encrypted = Convert.FromBase64String(
                "IAAAAABno2dbIBlOk0oARHXG4A+KzyVCKr2Q/AAKNGfrWjxVxNSkVEwinQveDPMkdyI6XpQRfIFEPVl0sKd6LqS+NULOQ1L4WU/Rew/bu29xDOkvixHgXyqT52MSxk2fM1Uauh91RqEhcLJ0nUre9gv/+yyqGFMH1adHC+26QM+pKSStKzZjhToUJNVGO5pS8C2QxYKNo+qVSlutgTe9Z6dufrgS9Zo/L0HpzspIpwevvPYMtHci7pdRnesyu55YCSdLyukROID0AuM0wr5BBXtZDS5MRq44RKbLdfsyVNQBRSdeZGgU1iuIGQwMwPjwH3jIle3MhBUyGZBDxMBED/dWaUHBXUOM8SHr37TInZ59B8zfWBcbtYLLpvhRTCD5bICtyg==");
            content = encrypted[36..];
            
            using (var ms = new MemoryStream())
            {
                var encryptor = aes.CreateDecryptor(key, iv);

                using var stream = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
                stream.Write(content, 0, content.Length);
                stream.FlushFinalBlock();
                decryptedContent = ms.ToArray();
            }

            Console.WriteLine(Utils.Unpack(decryptedContent));

            // Console.WriteLine(encrypted.Length); 
            //Console.WriteLine(string.Join(" ", encrypted.Select(b => $"{b:x2}")));

            /*
            encrypted = Convert.FromBase64String(
                "QAAAAEJyQUFuWJCC7e+OJO2/gP8fqaVbriUzAXNV2kcvn7sbAkzmsMUqmZZA8dqiWtRKw9Jq+wrBRBfYAG9uQ24e7w0/xYQWqrRAFc9HC9OUPuBS00K4+zy7sAwVQ+mddKwNQksjusv07f66wzcFdX8UYFiMOn+BFS6wUj3Yw0pwd66UZcADzL4qbu4xWL6yRjMMzzbUUBsLXnlYWG6O4P0BHtDSO9Cmm1FtN72LXD+gLkyRRW8F5F5x01/Tq7xY37dSP53MFWB9L/a40ckyUL1jS66woeJaaguTo1TfSG3BOCfgNHBgiWSzXkeExia4hfz5MRHttCt+vtYi4nqF61Aa4qetArMmmxPlnY2FfYLs6+VSGfC8iCH9vr7AVQpWRubPG366rSAjeqbMiwVYH0Tou8Ba0gY8P2Vpl1CFvXfVK1gE55JXca8uFF/sq6y6hbM5LjARY8cc/WkyB431m0DlZPSYSUpIVb7pFJzyFgX2p6nM");

            for (int i = 0; i < 32; ++i)
            {
                encrypted[i + 4] ^= header[i];
                encrypted[i + 4] ^= encrypted[i + 36];
            }

            Console.WriteLine(string.Join(" ", encrypted.Take(36).Select(b => $"{b:x2}")));

            byte[] key, iv;

            var sid = encrypted[4..20];
            var udid = encrypted[20..36];
            var content = encrypted[68..];

            var temp = udid.Concat(header.TakeLast(20)).ToArray();
            using (var md5 = MD5.Create("MD5"))
            {
                md5.TransformFinalBlock(temp, 0, temp.Length);
                iv = md5.Hash;
            }

            temp = sid.Concat(header.TakeLast(20)).ToArray();
            using (var md5 = MD5.Create("MD5"))
            {
                md5.TransformFinalBlock(temp, 0, temp.Length);
                key = md5.Hash;
            }

            byte[] decryptedContent;

            var aes = new RijndaelManaged();
            aes.BlockSize = 128;
            aes.Key = key;
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            using (var ms = new MemoryStream())
            {
                var encryptor = aes.CreateDecryptor(key, iv);

                using var stream = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
                stream.Write(content, 0, content.Length);
                stream.FlushFinalBlock();
                decryptedContent = ms.ToArray();
            }

            Console.WriteLine(Utils.Unpack(decryptedContent));


            encrypted = Convert.FromBase64String(
                "QAAAAI0Cvg5k7Uy12w/3RnOy/PLl5+DPpO/2OJkqBcd4KAZEAGBJ52qQsko07LKjlg3BglOnOHMlnduZ0oljHFfhvL0Jrf5eJ5sVWHhBC5Hg3WPmGY7aYAB6W6qOsR+Opx2oLoRIH0eYNRmRVEZZS+/eBBSXGrmipiB2jPlT6eGVLXEhb8FRzxND1HwJuNbdBaFyseUnDO5Xc7MYo5lqF9ARRc95ut7fWiHe1NZNBkJFNiYZNn7e6+HvfkgFNvRpBRLXBMpiqN965DzbZ6BdnZipdnxl87zfSZBTIDf2xWporO1nVy/L7uhZMeuONXpCJXb/BXmnvM6g5BXcynTZ3LU6dmkq3KVukfH4bcAPPJOisc2cotza5O5zDUCULyTLhmp6QZsD8SumcUbX6lRscgij8U0ujARbHIGAaajRHLQ0pTIyCzLPb/rv+StPnnKNdz4mrlc2H6U6uUN+si+Vl/DeK8eQEn55PmuC4ydkfyK8ie8/rKiWk+q9IXK4DbOaposTzA==");
            for (int i = 0; i < 32; ++i)
            {
                encrypted[i + 4] ^= header[i];
                encrypted[i + 4] ^= encrypted[i + 36];
            }

            Console.WriteLine(string.Join(" ", encrypted.Take(36).Select(b => $"{b:x2}")));
            
             sid = encrypted[4..20];
             udid = encrypted[20..36];
             content = encrypted[68..];

             temp = udid.Concat(header.TakeLast(20)).ToArray();
            using (var md5 = MD5.Create("MD5"))
            {
                md5.TransformFinalBlock(temp, 0, temp.Length);
                iv = md5.Hash;
            }

            temp = sid.Concat(header.TakeLast(20)).ToArray();
            using (var md5 = MD5.Create("MD5"))
            {
                md5.TransformFinalBlock(temp, 0, temp.Length);
                key = md5.Hash;
            }
            
             aes = new RijndaelManaged();
            aes.BlockSize = 128;
            aes.Key = key;
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            using (var ms = new MemoryStream())
            {
                var encryptor = aes.CreateDecryptor(key, iv);

                using var stream = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
                stream.Write(content, 0, content.Length);
                stream.FlushFinalBlock();
                decryptedContent = ms.ToArray();
            }

            Console.WriteLine(Utils.Unpack(decryptedContent));
            


            client.RetryRequest(new ToolGetPreDownloadResourceVersionRequest());


            //Console.WriteLine(string.Join(" ", encrypted.Select(b => $"{b:x2}")));*/
            /*
            UmamusumeClient client = new (new Account
            {
                //Udid = Guid.Parse("f3ba2056-6d23-c848-6587-6dcabcd74f73")
            }, new SimpleLz4Frame(0))
            {
                LogPrefix = string.Empty
            };


            client.ResetAccount();
            client.Signup();
            //var client = new UmamusumeClient(JsonConvert.DeserializeObject<Account>(File.ReadAllText("account.json")));
            //File.WriteAllText("account.json", JsonConvert.SerializeObject(client.Account));
            client.StartSession();
            client.Login();
            client.RetryRequest(new ChangeNameRequest
            {
                name = Utils.GenRandomPassword(Environment.TickCount64)[..8]
            });
            client.RetryRequest(new TutorialSkipRequest());

            client.StartSession();
            var login = client.Login();
            */
            Environment.Exit(0);
        }

        private static void Main(string[] args)
        {
            Test();
            Console.Write("线程数:");
            var tcount = int.Parse(Console.ReadLine());

            ThreadPool.SetMaxThreads(512, 512);
            ThreadPool.SetMinThreads(128, 128);

            foreach (var prop in JsonConvert.DeserializeObject<Dictionary<int, string>>(File.ReadAllText("extra.json")))
                cards.Add(prop.Key, prop.Value);

            conn = new SqliteConnection("data source=accounts.db");
            conn.Open();

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

            for (int i = 0; i < tcount; ++i)
            {
                int j = i;
                new Thread(() => RegisterTask(j)).Start();
                Thread.Sleep(500);
            }
        }
    }
}
