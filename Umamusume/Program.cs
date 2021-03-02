﻿using MsgPack;
using System;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading;
using Umamusume.Model;

namespace Umamusume
{
    internal class Program
    {
        private static SQLiteConnection conn;
        private static SQLiteConnection conn2;
        private static readonly string[] cl = "[B・N・Winner!!]ウイニングチケット	[千紫万紅にまぎれぬ一凛]グラスワンダー	[Run(my)way]ゴールドシチー	[夢は掲げるものなのだっ！]トウカイテイオー	[輝く景色の、その先に]サイレンススズカ	[不沈艦の進撃]ゴールドシップ	[はやい！うまい！はやい！]サクラバクシンオー	[パッションチャンピオーナ！]エルコンドルパサー	[待望の大謀]セイウンスカイ	[これが私のウマドル道☆]スマートファルコン	[感謝は指先まで込めて]ファインモーション	[まだ小さな蕾でも]ニシノフラワー	[天をも切り裂くイナズマ娘！]タマモクロス	[一粒の安らぎ]スーパークリーク	[日本一のステージを]スペシャルウィーク	[ロード・オブ・ウオッカ]ウオッカ	[7センチの先へ]エアシャカール	[必殺！Wキャロットパンチ！]ビコーペガサス	[ようこそ、トレセン学園へ！]駿川たづな	[飛び出せ、キラメケ]アイネスフウジン"
            .Split("	").ToArray();

        private static void SaveTo(UmamusumeClient client, SQLiteConnection conn)
        {
            string pwd = Utils.GenRandomPassword();
            client.Request(new ChangeNameRequest
            {
                name = "init"
            });
            client.PublishTransition(pwd);
            client.Account.extra.password = pwd;
            const string qstr = "insert into accounts (udid, authkey, password, cardnum, viewer_id, {0}) values (@udid, @authkey, @password, @cardnum, @viewer_id, {1})";

            SQLiteCommand cmd = new SQLiteCommand(string.Format(qstr, string.Join(",", cl.Select(s => s[1..(s.IndexOf("]") - 1)]).Select(s => $"`{s}`")), string.Join(",", Enumerable.Range(1, cl.Length).Select(i => $"@c{i}"))), conn);
            cmd.Parameters.Add("udid", DbType.String).Value = client.Account.Udid.ToString();
            cmd.Parameters.Add("authkey", DbType.String).Value = client.Account.Authkey;
            cmd.Parameters.Add("password", DbType.String).Value = client.Account.extra.password;
            int i = 0;
            foreach (string c in cl)
                cmd.Parameters.Add($"c{++i}", DbType.Int32).Value = client.Account.extra.support_cards.TryGetValue(c, out int val) ? val : 0;
            cmd.Parameters.Add("cardnum", DbType.Int32).Value = client.Account.extra.support_cards.Count;
            cmd.Parameters.Add("viewer_id", DbType.Int32).Value = client.Account.ViewerId;
            lock (conn)
                cmd.ExecuteNonQuery();
        }
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
                    client.Request(new TutorialSkipRequest());

                    client.StartSession();
                    client.Login();
                    client.ReceivePresents();
                    var gachas = client.Request(new GachaLoadRequest()).data.gacha_info_list;
                    var gachaid = gachas.First(gachas => gachas.id / 10000 == 3 &&
                        gachas.is_campaign_draw_enable_single == 1 &&
                        gachas.is_campaign_draw_enable_multi == 0);

                    while (client.FCoin >= 1500)
                    {
                        client.Gacha(gachaid.id);
                        Thread.Sleep(700);
                    }
                    client.Gacha(20002, 1, 114, 1);
                    Console.WriteLine($"[Thread #{id}] gacha get = {client.Account.extra.support_cards.Count}");

                    if (client.Account.extra.support_cards.Count > 5)
                    {
                        SaveTo(client, conn);
                    }
                    else if (client.Account.extra.support_cards.Count == 5)
                    {
                        var sc = client.Account.extra.support_cards;
                        if (sc.ContainsKey("[まだ小さな蕾でも]ニシノフラワー") && sc.ContainsKey("[ようこそ、トレセン学園へ！]駿川たづな"))
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
            Console.WriteLine(string.Join(",", new BoxingPacker().Pack("374b909de679462599a92f904d46ea7d").Select(i => $"{i:x2}")));
            var client = new UmamusumeClient(new Account
            {
                Udid = Guid.Parse("45ad69a1-c6f4-41f0-ad8f-cac997beacb0")
            }, new SimpleLz4Frame(0))
            {
                LogPrefix = ""
            };

            client.Signup();
        }

        private static void Main(string[] args)
        {
            ThreadPool.SetMaxThreads(512, 512);
            ThreadPool.SetMaxThreads(128, 128);
            conn = new SQLiteConnection("data source=accounts.db");
            conn.Open();
            conn2 = new SQLiteConnection("data source=accounts2.db");
            conn2.Open();

            try
            {
                new SQLiteCommand("create table if not exists accounts(" +
                    "cardnum INTEGER," +
                    string.Concat(cl.Select(s => s[1..(s.IndexOf("]") - 1)]).Select(c => $"`{c}` INTEGER,")) +
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
                    string.Concat(cl.Select(s => s[1..(s.IndexOf("]") - 1)]).Select(c => $"`{c}` INTEGER,")) +
                    "viewer_id INTEGER," +
                    "password TEXT," +
                    "udid TEXT," +
                    "authkey TEXT);", conn2).ExecuteNonQuery();

                new SQLiteCommand("create unique index id_index on accounts (viewer_id)", conn2).ExecuteNonQuery();
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
