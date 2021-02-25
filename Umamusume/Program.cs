using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Umamusume.Model;

namespace Umamusume
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts;
            try
            {
                accounts = JsonConvert.DeserializeObject<List<Account>>(File.ReadAllText("accounts.json"));
            }
            catch
            {
                accounts = new List<Account>();
            }
            var client = new UmamusumeClient();
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
                client.ReceivePresents();
                client.Gacha(30003);
                Thread.Sleep(500);
                client.Gacha(30003);
                Thread.Sleep(500);
                client.Gacha(30003);
                Console.WriteLine($"gacha get = {client.Account.extra.support_cards.Count}");

                if (client.Account.extra.support_cards.Count > 1)
                {
                    accounts.Add(client.Account);
                    File.WriteAllText($"accounts.json", JsonConvert.SerializeObject(accounts, Formatting.Indented));
                    string pwd = Utils.GenRandomPassword();
                    client.Account.extra.password = pwd;
                    client.PublishTransition(pwd);
                    File.WriteAllText($"accounts.json", JsonConvert.SerializeObject(accounts, Formatting.Indented));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            client.ResetAccount();
            goto signup;
        }
    }
}
