using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LitJson;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using MsgPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Umamusume;
using Umamusume.Model;

namespace PCRAgent.Controllers
{
    public class Ref<T>
    {
        public T value;
    }

    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly ILogger<ApiController> _logger;
        private readonly HttpClient client;
        private static TextWriter filelog;

        private void LogInformation(string info)
        {
            if (filelog == null) filelog = new StreamWriter(new FileStream("api.log", FileMode.Append, FileAccess.Write));
            filelog.WriteLine(info);
            filelog.Flush();
            _logger.LogInformation(info);
        }

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
            WebRequest.DefaultWebProxy = null;
            client = new HttpClient(new HttpClientHandler()
            {
                Proxy = new WebProxy("localhost:1080"),
                UseProxy = true
            })
            {
                Timeout = new TimeSpan(0, 0, 10)
            };
            var headertype = typeof(HttpClient).Assembly.GetType("System.Net.Http.Headers.HttpHeaderType");
            typeof(HttpHeaders).GetField("_allowedHeaderTypes", bindingAttr: BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(client.DefaultRequestHeaders, Enum.Parse(headertype, "All"));
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-msgpack");
        }

        public static string Unpack(byte[] crypted, out byte[] key)
        {

            RijndaelManaged aes = new RijndaelManaged
            {
                Mode = CipherMode.CBC,
                KeySize = 256,
                BlockSize = 128,
                Padding = PaddingMode.PKCS7
            };
            var n = crypted.Length;
            key = crypted.Skip(n - 32).ToArray();
            var transform = aes.CreateDecryptor(key, Encoding.UTF8.GetBytes("ha4nBYA2APUD6Uv1"));
            var buf = transform.TransformFinalBlock(crypted.Take(n - 32).ToArray(), 0, n - 32);
            return Encoding.UTF8.GetString(buf);
        }

        public static byte[] Pack(JToken token)
        {
            Func<JToken, object> mapper = null;

            mapper = o =>
            {
                if (o is JArray arr) return arr.Select(mapper).ToArray();
                else if (o is JObject obj) return new Dictionary<string, object>(
                    obj.Properties().Select(prop => new KeyValuePair<string, object>(prop.Name, mapper(prop.Value)))
                );
                else return o.ToObject<object>();
            };

            object mapped = mapper(token);

            return new BoxingPacker().Pack(mapped);
        }
        public static JToken Unpack(byte[] content)
        {
            return JToken.FromObject(new BoxingPacker().Unpack(content));
        }

        private static ICryptHandler cryptor = new SimpleLz4Frame(10);
        private static Guid guid = Guid.NewGuid();

        private void PostLogin(HttpClient client)
        {
            client.DefaultRequestHeaders.Clear();

            var headerIgnores = new HashSet<string>() { "Host", "Content-Length" };

            Type headertype = typeof(HttpClient).Assembly.GetType("System.Net.Http.Headers.HttpHeaderType");
            typeof(HttpHeaders).GetField("_allowedHeaderTypes", bindingAttr: BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(client.DefaultRequestHeaders, Enum.Parse(headertype, "All"));
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-msgpack");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "deflate, gzip");
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "UnityPlayer/2019.4.21f1 (UnityWebRequest/1.0, libcurl/7.52.0-DEV)");
            client.DefaultRequestHeaders.TryAddWithoutValidation("X-Unity-Version", "2019.4.21f1");
            client.DefaultRequestHeaders.TryAddWithoutValidation("APP-VER", "1.7.1");
            client.DefaultRequestHeaders.TryAddWithoutValidation("RES-VER", "");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Device", "2");
            client.DefaultRequestHeaders.TryAddWithoutValidation("ViewerID", "0");

            RequestCommon env = new ToolSignupRequest
            {
                credential = "",
                error_code = 0,
                error_message = ""
            };
            env.UpdateInfo(RequestEnvironment.CreateDefault(), new Account { ViewerId = 0 });
            var packed = JToken.FromObject(env);
            var sid = Utils.Bin2Hex(Utils.MakeMd5($"0{guid}"));
            var header = Convert.FromBase64String("ayDiq2wxEzD3Ydc3zj8wJXUIUGZe6li2Ny+NL1dQHrNzKcvKzUI6otWXsmanSJ1GqHNyuQ==");
            var req = new byte[] { 116, 0, 0, 0 }.Concat(header).Concat(Utils.Hex2bin(sid)).Concat(Utils.Hex2bin(guid.ToString().Replace("-", "")))
                .Concat(Utils.GenRandomBytes(32)).Concat(Pack(packed)).ToArray();
            client.DefaultRequestHeaders.TryAddWithoutValidation("SID", sid);

            var data = cryptor.Compress(req);
            var response = client.PostAsync($"https://api-umamusume.cygames.jp/umamusume/tool/signup", new ByteArrayContent(Encoding.UTF8.GetBytes(data))).Result;
            var respdata = response.Content.ReadAsStringAsync().Result;

            var datar = cryptor.Decompress(respdata);
            LogInformation($"resdata = {Unpack(datar).ToString(Formatting.Indented)}");
        }
        [HttpPost("{game}/{route}/{method}")]
        public ActionResult<string> Post(string game, string route, string method)
        {
            var sr = new StreamReader(Request.Body);
            var reqdata = Convert.FromBase64String(JObject.Parse(sr.ReadToEndAsync().Result)["data"].ToString());

            client.DefaultRequestHeaders.Clear();

            var headerIgnores = new HashSet<string>() { "Host", "Content-Length"};

            Type headertype = typeof(HttpClient).Assembly.GetType("System.Net.Http.Headers.HttpHeaderType");
            typeof(HttpHeaders).GetField("_allowedHeaderTypes", bindingAttr: BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(client.DefaultRequestHeaders, Enum.Parse(headertype, "All"));
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-msgpack");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "deflate, gzip");
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "UnityPlayer/2019.4.21f1 (UnityWebRequest/1.0, libcurl/7.52.0-DEV)");
            client.DefaultRequestHeaders.TryAddWithoutValidation("X-Unity-Version", "2019.4.21f1");
            client.DefaultRequestHeaders.TryAddWithoutValidation("APP-VER", "1.7.1");
            client.DefaultRequestHeaders.TryAddWithoutValidation("RES-VER", "");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Device", "2");
            /*
            foreach (var header in Request.Headers)
            {
                if (headerIgnores.Contains(header.Key)) continue;
                client.DefaultRequestHeaders.TryAddWithoutValidation(header.Key, (string[])header.Value);
            }*/

            LogInformation($"calling api {route}/{method} (requestid={Request.Headers["REQUEST-ID"]}, sid=)");

            var req = Convert.FromBase64String(Encoding.UTF8.GetString(reqdata));
            //guid = Guid.ParseExact(Utils.Bin2Hex(req[104..120]).ToString().Replace("-", ""), "N");
            var sid = Utils.Bin2Hex(Utils.MakeMd5($"0{guid}"));
            RequestCommon env = method == "pre_signup" ? new ToolPreSignupRequest() : new ToolSignupRequest
            {
                credential = "",
                error_code = 0,
                error_message = ""
            };
            env.UpdateInfo(RequestEnvironment.CreateDefault(), new Account { ViewerId = 0 });
            var packed = JToken.FromObject(env);
            //if (method != "signup")
                req = new byte[] { 116, 0, 0, 0 }.Concat(req[4..56]).Concat(Utils.Hex2bin(sid)).Concat(Utils.Hex2bin(guid.ToString().Replace("-", "")))
                    .Concat(Utils.GenRandomBytes(32)).Concat(Pack(packed)).ToArray();
            //else
            //    req = new byte[] { 116, 0, 0, 0 }.Concat(req[4..56]).Concat(Utils.Hex2bin(sid)).Concat(Utils.Hex2bin(guid.ToString().Replace("-", "")))
            //        .Concat(req[120..]).ToArray();
            //client.DefaultRequestHeaders.Remove("SID");
            client.DefaultRequestHeaders.TryAddWithoutValidation("SID", sid);

            int index = 4 + BitConverter.ToInt32(req);
            var req1 = Unpack(req.Skip(index).ToArray());
            LogInformation($"reqdata = {req1.ToString(Formatting.Indented)}");
            Console.WriteLine(string.Join(" ", req.Take(index).Select(i => $"{i:x2}")));
            var data = cryptor.Compress(req.Take(index).Concat(Pack(req1)).ToArray());

            //var response = client.PostAsync($"https://localhost:444/{route}/{method}", new ByteArrayContent(reqdata)).Result;

            Console.WriteLine($"posting rd {Convert.ToBase64String(req.Skip(88).Take(32).ToArray())}");
            Console.WriteLine($"posting req {data}");
            var response = client.PostAsync($"https://api-umamusume.cygames.jp/{game}/{route}/{method}", new ByteArrayContent(Encoding.UTF8.GetBytes(data))).Result;
            var respdata = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine("posted");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Console.WriteLine(response.StatusCode);
                return BadRequest();
            }

            var datar = cryptor.Decompress(respdata);

            LogInformation($"resdata = {Unpack(datar).ToString(Formatting.Indented)}");

            Response.Headers.Clear();

            foreach (var header in response.Headers)
            {
                if (header.Key.StartsWith("X-")) continue;
                if (header.Key == "Connection" || header.Key == "Transfer-Encoding") continue;
                //Response.Headers.Add(header.Key, (string[])header.Value);
            }
            new Thread(() =>
            {
                Console.ReadLine();
                PostLogin(client);
            }).Start();
            return new ActionResult<string>(Convert.ToBase64String(datar));
        }
    }
}
