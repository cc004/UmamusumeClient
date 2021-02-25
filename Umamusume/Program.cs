using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Threading;
using Umamusume.Model;

namespace Umamusume
{
    class Program
    {
        private static SQLiteConnection conn;
        private static int i;
        private static SQLiteTransaction trans;

        private static void RegisterTask(int id)
        {
            var client = new UmamusumeClient(new SimpleLz4Frame(id));
            client.LogPrefix = $"[Thead #{id}]";
            signup:
            try
            {
                client.Signup();
                //var client = new UmamusumeClient(JsonConvert.DeserializeObject<Account>(File.ReadAllText("account.json")));
                //File.WriteAllText("account.json", JsonConvert.SerializeObject(client.Account));
                client.StartSession();
                client.Login();
                client.Request(new TutorialSkipRequest());

                client.StartSession();
                client.Login();
                client.Request(new ChangeNameRequest
                {
                    name = "init"
                });
                client.ReceivePresents();
                client.Gacha(30003);
                Thread.Sleep(500);
                client.Gacha(30003);
                Thread.Sleep(500);
                client.Gacha(30003);
                Console.WriteLine($"gacha get = {client.Account.extra.support_cards.Count}");

                if (client.Account.extra.support_cards.Count > -1)
                {
                    string pwd = Utils.GenRandomPassword();
                    client.PublishTransition(pwd);
                    client.Account.extra.password = pwd;
                    const string qstr = "insert into accounts (udid, authkey, password, cards, cardnum, viewer_id) values (@udid, @authkey, @password, @cards, @cardnum, @viewer_id)";
                    
                    lock (conn)
                    {
                        if (++i % 10 == 0)
                        {
                            trans.Commit();
                            trans = conn.BeginTransaction();
                        }
                        var cmd = new SQLiteCommand(qstr, conn);
                        cmd.Parameters.Add("udid", DbType.String).Value = client.Account.Udid.ToString();
                        cmd.Parameters.Add("authkey", DbType.String).Value = client.Account.Authkey;
                        cmd.Parameters.Add("password", DbType.String).Value = client.Account.extra.password;
                        cmd.Parameters.Add("cards", DbType.String).Value = string.Join("\n", client.Account.extra.support_cards);
                        cmd.Parameters.Add("cardnum", DbType.Int32).Value = client.Account.extra.support_cards.Count;
                        cmd.Parameters.Add("viewer_id", DbType.Int32).Value = client.Account.ViewerId;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"[Thread #{id}] {e}");
            }
            client.ResetAccount();
            goto signup;
        }
        static void Main(string[] args)
        {
            ThreadPool.SetMaxThreads(512, 512);
            ThreadPool.SetMaxThreads(128, 128);
            conn = new SQLiteConnection("data source=accounts.db");
            conn.Open();
            trans = conn.BeginTransaction();

            try
            {
                new SQLiteCommand("create table if not exists accounts(" +
                    "TEXT udid," +
                    "TEXT authkey," +
                    "TEXT password," +
                    "TEXT cards," +
                    "INTEGER cardnum," +
                    "INTEGER viewer_id)").ExecuteNonQuery();

                new SQLiteCommand("create unique index id_index on accounts (viewer_id)", conn).ExecuteNonQuery();
            }
            catch
            {

            }

            for (int i = 0; i < 16; ++i)
            {
                int j = i;
                new Thread(new ThreadStart(() => RegisterTask(j))).Start();
                Thread.Sleep(5000);
            }
        }
    }
}
