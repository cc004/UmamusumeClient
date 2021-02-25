using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;

namespace Umamusume
{
	public static class SimpleLz4Frame
	{
		private static HttpClient client = new HttpClient(new HttpClientHandler()
		{
			Proxy = null,
			UseProxy = false
		});
		private static object locker = new object();

		static SimpleLz4Frame()
		{
			client.DefaultRequestHeaders.Clear();
		}

		public static byte[] Decompress(string src)
		{
			var enc = HttpUtility.UrlEncode(src);
			lock (locker)
				return Convert.FromBase64String(client.GetStringAsync($"http://localhost:2333/decompress?content={enc}").Result);
		}
		public static string Compress(byte[] src)
		{
			if (Convert.ToBase64String(src) == "dAAAAGsg4qtsMRMw92HXN84/MCV1CFBmXupYtjcvjS9XUB6zGLFLl+B373dZv9P2HAVI475djC24skGuPcUl2lBOyu9kAz3X3l/lCm8CTamYrl40IVimOgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAiql2aWV3ZXJfaWQApmRldmljZQKpZGV2aWNlX2lk2gAgMzc0YjkwOWRlNjc5NDYyNTk5YTkyZjkwNGQ0NmVhN2SrZGV2aWNlX25hbWWrT1BQTyBQQ1JUMDC0Z3JhcGhpY3NfZGV2aWNlX25hbWWvQWRyZW5vIChUTSkgNjQwqmlwX2FkZHJlc3OpMTAuMC4yLjE1s3BsYXRmb3JtX29zX3ZlcnNpb27aAD9BbmRyb2lkIE9TIDcuMS4yIC8gQVBJLTI1IChOMkc0OEgvcmVsLnNlLmluZnJhLjIwMjAwNzMwLjE1MDUyNSmnY2FycmllcqRPUFBPqGtleWNoYWluAKZsb2NhbGWjSlBO")
				return "XwEAACjBEk5kjbC+B3LqtzXYIZq3kW9aU08WFyVpg2bKBnIJ/zXrPLsxqGAQfwWeNdopk6qcy7C0SqxRagr7W7RwmsPpfiaL4JZohtOUkUhtiTN6xfNsWUMvJnyr3arJE14HT94Wq8D3VVznTctNk46PtP96scuckzBy/xf68dqKQpnps7bxrsxYB5oH48F/WeoQ8vagSA9CG+cFzy8veZQ0cMIcPuJ+dF8Gj9RFUOniIhC13iiCywD4gQcXpiviQXdl/SAkAMIHdf5cLw28Tk0mkfEFzNcnogktta1JyWHcygJLNM+VNPKy1RlPyijzb9X98xPnw+iiGZ0+Ld/ZwR8dk3ix5iG+dd5YEh5QrqEWFUvE3pdi+bdXGRcY2S2YaZcIFI4ptvO5z30SErNo3QyhsaQ9nqKqZWjgvG+lQUBd7sSnKNETLp2eRV50Do80GhIUFdAuSkp+HpQ6hNE1WbOk5w==";
			var enc = HttpUtility.UrlEncode(Convert.ToBase64String(src));
			lock (locker)
				return client.GetStringAsync($"http://localhost:2333/compress?content={enc}").Result;
		}
	}
}
