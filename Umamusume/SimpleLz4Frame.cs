using System;
using System.Net.Http;

namespace Umamusume
{
    public interface ICryptHandler
    {
        byte[] Decompress(string src);
        string Compress(byte[] src);
    }

    public class SimpleLz4Frame : ICryptHandler
    {
        private readonly HttpClient client = new HttpClient(new HttpClientHandler()
        {
            Proxy = null,
            UseProxy = false
        });

        private readonly int id;
        private readonly bool crypt;

        private static readonly bool dbg = UmamusumeClient.dbg;

        public SimpleLz4Frame(int id, bool crypt = true)
        {
            this.id = id;
            this.crypt = crypt;
            client.DefaultRequestHeaders.Clear();
        }

        public byte[] Decompress(string src)
        {
            if (dbg) Console.WriteLine($"decompressing: {src}");
            if (!crypt) return Convert.FromBase64String(src);
            return Convert.FromBase64String(client.PostAsync($"http://localhost:2333/{id}/decompress", new StringContent(src)).Result.Content.ReadAsStringAsync().Result);
        }
        public string Compress(byte[] src)
        {
            if (dbg) Console.WriteLine($"compressing: {Convert.ToBase64String(src)}");
            if (!crypt) return Convert.ToBase64String(src);
            return client.PostAsync($"http://localhost:2333/{id}/compress", new StringContent(Convert.ToBase64String(src))).Result.Content.ReadAsStringAsync().Result;
        }
    }
}
