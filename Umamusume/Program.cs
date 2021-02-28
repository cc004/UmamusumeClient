using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Threading;
using Umamusume.Model;

namespace Umamusume
{
    class Program
    {
        private static SQLiteConnection conn;
        private readonly static string[] cl = "[B・N・Winner!!]ウイニングチケット	[千紫万紅にまぎれぬ一凛]グラスワンダー	[Run(my)way]ゴールドシチー	[夢は掲げるものなのだっ！]トウカイテイオー	[輝く景色の、その先に]サイレンススズカ	[不沈艦の進撃]ゴールドシップ	[はやい！うまい！はやい！]サクラバクシンオー	[パッションチャンピオーナ！]エルコンドルパサー	[待望の大謀]セイウンスカイ	[これが私のウマドル道☆]スマートファルコン	[感謝は指先まで込めて]ファインモーション	[まだ小さな蕾でも]ニシノフラワー	[天をも切り裂くイナズマ娘！]タマモクロス	[一粒の安らぎ]スーパークリーク	[日本一のステージを]スペシャルウィーク	[ロード・オブ・ウオッカ]ウオッカ	[7センチの先へ]エアシャカール	[必殺！Wキャロットパンチ！]ビコーペガサス	[ようこそ、トレセン学園へ！]駿川たづな	[飛び出せ、キラメケ]アイネスフウジン"
            .Split("	").ToArray();

        private static void RegisterTask(int id)
        {
            var client = new UmamusumeClient(new SimpleLz4Frame(id));
            client.LogPrefix = $"[Thread #{id}]";
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
                while (client.FCoin >= 1500)
                {
                    client.Gacha(30003);
                    Thread.Sleep(700);
                }
                Console.WriteLine($"gacha get = {client.Account.extra.support_cards.Count}");

                if (client.Account.extra.support_cards.Count > 4)
                {
                    string pwd = Utils.GenRandomPassword();
                    client.PublishTransition(pwd);
                    client.Account.extra.password = pwd;
                    const string qstr = "insert into accounts (udid, authkey, password, cardnum, viewer_id, {0}) values (@udid, @authkey, @password, @cardnum, @viewer_id, {1})";
                    
                    lock (conn)
                    {
                        var cmd = new SQLiteCommand(string.Format(qstr, string.Join(",", cl.Select(s => $"`{s}`")), string.Join(",", Enumerable.Range(1, cl.Length).Select(i => $"@c{i}"))), conn);
                        cmd.Parameters.Add("udid", DbType.String).Value = client.Account.Udid.ToString();
                        cmd.Parameters.Add("authkey", DbType.String).Value = client.Account.Authkey;
                        cmd.Parameters.Add("password", DbType.String).Value = client.Account.extra.password;
                        int i = 0;
                        foreach (var c in cl)
                            cmd.Parameters.Add($"c{++i}", DbType.Int32).Value = client.Account.extra.support_cards.TryGetValue(c, out var val) ? val : 0;
                        cmd.Parameters.Add("cardnum", DbType.Int32).Value = client.Account.extra.support_cards.Sum(pair => pair.Value);
                        cmd.Parameters.Add("viewer_id", DbType.Int32).Value = client.Account.ViewerId;
                        cmd.ExecuteNonQuery();
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
            try
            {
                new SQLiteCommand("create table if not exists accounts(" +
                    "cardnum INTEGER," +
                    string.Concat(cl.Select(c => $"`{c}` INTEGER,")) +
                    "viewer_id INTEGER," +
                    "password TEXT," +
                    "udid TEXT," +
                    "authkey TEXT);", conn).ExecuteNonQuery();

                new SQLiteCommand("create unique index id_index on accounts (viewer_id)", conn).ExecuteNonQuery();
            }
            catch
            {

            }

            for (int i = 0; i < 32; ++i)
            {
                int j = i;
                new Thread(new ThreadStart(() => RegisterTask(j))).Start();
                Thread.Sleep(2000);
            }
        }
    }
}
