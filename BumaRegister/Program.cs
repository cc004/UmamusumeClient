
using System.Net;
using Newtonsoft.Json;
using Umamusume;
using Umamusume.Model;

var list = new List<BumaAccount>();
try
{
    list = JsonConvert.DeserializeObject<List<BumaAccount>>(File.ReadAllText("buma_accounts.json"));
}
catch
{

}

for (int i = 0; i < 30; ++i)
new Thread(() =>
{
    var client = new BumaClient(UmamusumeClient.appver, new HttpClient(new HttpClientHandler()
    {
        UseProxy = true,
        Proxy = new WebProxy("127.0.0.1:1080"),
    })
    {
        Timeout = TimeSpan.FromSeconds(5)
    });
    for(;;)
    try
    {
        client.Signup();
        Console.WriteLine(client.Account.uid);
        lock (list)
        {
            list.Add(client.Account);
            File.WriteAllText("buma_accounts.json", JsonConvert.SerializeObject(list, Formatting.Indented));
        }
    }
    catch
    {
        client.Dispose();
        client = new BumaClient(UmamusumeClient.appver, new HttpClient(new HttpClientHandler()
        {
            UseProxy = true,
            Proxy = new WebProxy("127.0.0.1:1080")
        })
        {
            Timeout = TimeSpan.FromSeconds(5)
        });
    }
}).Start();
