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
		private object locker = new object();
		private int id;

		public SimpleLz4Frame(int id)
		{
			this.id = id;
			client.DefaultRequestHeaders.Clear();
		}

		public byte[] Decompress(string src)
		{
			var enc = HttpUtility.UrlEncode(src);
			lock (locker)
				return Convert.FromBase64String(client.GetStringAsync($"http://localhost:2333/{id}/decompress?content={enc}").Result);
		}
		public string Compress(byte[] src)
		{
			var enc = HttpUtility.UrlEncode(Convert.ToBase64String(src));
			lock (locker)
				return client.GetStringAsync($"http://localhost:2333/{id}/compress?content={enc}").Result;
		}
	}
}
