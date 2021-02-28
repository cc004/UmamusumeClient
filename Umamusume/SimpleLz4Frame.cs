using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;

namespace Umamusume
{
	public interface ICryptHandler
    {
		byte[] Decompress(string src);
		string Compress(byte[] src);
    }

	public class SimpleLz4Frame : ICryptHandler
	{
		private HttpClient client = new HttpClient(new HttpClientHandler()
		{
			Proxy = null,
			UseProxy = false
		});

		private readonly int id;

		public SimpleLz4Frame(int id)
		{
			this.id = id;
			client.DefaultRequestHeaders.Clear();
		}

		public byte[] Decompress(string src)
		{
			return Convert.FromBase64String(client.PostAsync($"http://localhost:2333/{id}/decompress", new StringContent(src)).Result.Content.ReadAsStringAsync().Result);
		}
		public string Compress(byte[] src)
		{
			return client.PostAsync($"http://localhost:2333/{id}/compress", new StringContent(Convert.ToBase64String(src))).Result.Content.ReadAsStringAsync().Result;
		}
	}
}
