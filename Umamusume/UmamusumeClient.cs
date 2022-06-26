using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Umamusume.Model;

namespace Umamusume
{
    public class ApiException : Exception
    {
        public GallopResultCode ResultCode;
        public Tuple<string, string> pair;


        public ApiException(string req, string res, string msg) : base(msg)
        {
            pair = new Tuple<string, string>(req, res);
        }

        public ApiException(string req, string res, HttpStatusCode code) : this(req, res, code.ToString())
        {
        }
        public ApiException(string req, string res, GallopResultCode code) : this(req, res, code.ToString())
        {
            ResultCode = code;
        }
    }

    public class UmamusumeClient
    {
        public const bool dbg = false;
        internal static string header;// = "ayDiq2wxEzD3Ydc3zj8wJXUIUGZe6li2Ny+NL1dQHrOkm+SczQccvfO8S1xFXOpCL3d2Og==";
        private static string appver;// = "1.2.10";
        private static byte platform;

        static UmamusumeClient()
        {
            var json = JObject.Parse(File.ReadAllText("env.json"));
            header = json.Value<string>("header");
            appver = json.Value<string>("appver");
            platform = json.Value<byte>("platform");
        }

        private const string apiroot = "https://l13-prod-all-gs-uma.komoejoy.com";
        private const string proxy_server = "127.0.0.1:1080";

        public static int _reqnum = 0;

        public static int Reqnum => Interlocked.Exchange(ref _reqnum, 0);

        public Account Account { get; private set; }
        private HttpClient client = CreateHttpClient();

        public RequestEnvironment env = RequestEnvironment.CreateDefault();

        private string resver;

        public int FCoin { get; private set; }
        public int current_money { get; private set; }
        public TpInfo tpInfo { get; private set; }

        public string ResVer
        {
            get => resver;
            private set
            {
                resver = value;
                //Console.WriteLine($"resver changed into {resver}");
                client.DefaultRequestHeaders.Remove("RES-VER");
                client.DefaultRequestHeaders.TryAddWithoutValidation("RES-VER", resver);
            }
        }

        private string session_id;
        private string SessionId => session_id ?? Account.SessionId;
        
        public UmamusumeClient() : this(new Account()) { }

        public string LogPrefix;

        private static void AddCommonHeaders(HttpClient client)
        {
            Type headertype = typeof(HttpClient).Assembly.GetType("System.Net.Http.Headers.HttpHeaderType");
            typeof(HttpHeaders).GetField("_allowedHeaderTypes", bindingAttr: BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(client.DefaultRequestHeaders, Enum.Parse(headertype, "All"));
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-msgpack");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "deflate, gzip");
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "UnityPlayer/2019.4.21f1 (UnityWebRequest/1.0, libcurl/7.52.0-DEV)");
            client.DefaultRequestHeaders.TryAddWithoutValidation("X-Unity-Version", "2019.4.21f1");
            client.DefaultRequestHeaders.TryAddWithoutValidation("APP-VER", appver);
            client.DefaultRequestHeaders.TryAddWithoutValidation("RES-VER", "00000000");
            client.DefaultRequestHeaders.TryAddWithoutValidation("BUMA-OPEN-ID", "0");
        }

        public UmamusumeClient(Account account)
        {
            Account = account;
            client.DefaultRequestHeaders.Clear();
            client.Timeout = new TimeSpan(0, 0, 30);
            AddCommonHeaders(client);
            ResVer = "10002000";
        }

        private void PreRequestHeaders()
        {
            client.DefaultRequestHeaders.TryAddWithoutValidation("SID", SessionId);
            client.DefaultRequestHeaders.TryAddWithoutValidation("ViewerID", Account.ViewerId.ToString());
            client.DefaultRequestHeaders.TryAddWithoutValidation("BUMA-RID", 
                Utils.Bin2Hex(Utils.MakeMd5(string.Concat(new object[]
                {
                    Account.Udid,
                    Account.SessionId,
                    DateTime.Now.ToUniversalTime().ToFileTimeUtc(),
                    $"{Account.ViewerId:D12}"
                }))));
        }
        private void PostRequestHeaders()
        {
            client.DefaultRequestHeaders.Remove("SID");
            client.DefaultRequestHeaders.Remove("ViewerID");
            client.DefaultRequestHeaders.Remove("BUMA-RID");
        }

        public TResult RetryRequest<TResult>(RequestBase<TResult> request, int count = 3, int interval = 1000) where TResult : ResponseCommon
        {
            while (true)
            {
                try
                {
                    Thread.Sleep(interval);
                    return Request(request);
                }
                catch (ApiException)
                {
                    throw;
                }
                catch (Exception e)
                {
                    if (--count == 0) throw;
                }
            }
        }

        private static HttpClient CreateHttpClient() => new HttpClient(new HttpClientHandler()
        {
            UseProxy = true,
            Proxy = new WebProxy(proxy_server)
        });

        public void ResetConnection()
        {
            Type headertype = typeof(HttpClient).Assembly.GetType("System.Net.Http.Headers.HttpHeaderType");
            HttpClient client = CreateHttpClient();


            typeof(HttpHeaders).GetField("_allowedHeaderTypes", bindingAttr: BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(client.DefaultRequestHeaders, Enum.Parse(headertype, "All"));

            client.DefaultRequestHeaders.Clear();

            foreach (KeyValuePair<string, IEnumerable<string>> header in this.client.DefaultRequestHeaders)
                client.DefaultRequestHeaders.TryAddWithoutValidation(header.Key, header.Value);
            this.client.Dispose();
            this.client = client;
        }

        private TResult Request<TResult>(RequestBase<TResult> request) where TResult : ResponseCommon
        {
            request.UpdateInfo(env, Account);
            var content = Utils.Pack(JToken.FromObject(request));
            if (dbg) Console.WriteLine(JsonConvert.SerializeObject(request, Formatting.Indented));


            var rnd = Utils.GenRandomBytes(32);
            rnd[0] = 0; //platform id
            var header = Convert.FromBase64String(UmamusumeClient.header);
            var udid = Utils.Hex2bin(Account.Udid.ToString().Replace("-", "")).FillTo(16);
            var sid = Utils.Hex2bin(SessionId).FillTo(16);

            //udid = Utils.Hex2bin()

            var head = sid
                .Concat(udid)
                .Concat(rnd);
            if (Account.Authkey != null) head = head.Concat(Convert.FromBase64String(Account.Authkey));
            var head2 = head.ToArray();
            var headCount = BitConverter.GetBytes(head2.Length);
            var fullHeader = headCount.Concat(head2).ToArray();

            byte[] key, iv;

            var temp = udid.Concat(header.TakeLast(20)).ToArray();
            using (var md5 = MD5.Create("MD5"))
            {
                md5.TransformFinalBlock(temp, 0, temp.Length);
                iv = md5.Hash;
            }

            temp = sid.Concat(header.TakeLast(20)).ToArray();
            using (var md5 = MD5.Create("MD5"))
            {
                md5.TransformFinalBlock(temp, 0, temp.Length);
                key = md5.Hash;
            }

            byte[] encryptedContent;

            var aes = new RijndaelManaged();
            aes.BlockSize = 128;
            aes.Key = key;
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            using (var ms = new MemoryStream())
            {
                var encryptor = aes.CreateEncryptor(key, iv);

                using var stream = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
                stream.Write(content, 0, content.Length);
                stream.FlushFinalBlock();
                encryptedContent = ms.ToArray();
            }

            var fullContent = fullHeader.Concat(encryptedContent).ToArray();

            for (var i = 0; i < 32; ++i)
            {
                fullContent[i + 4] ^= rnd[i];
                fullContent[i + 4] ^= header[i];
            }
            
            var crypted = Convert.ToBase64String(fullContent);

            PreRequestHeaders();
            HttpResponseMessage resp;
            var apiurl = request.GetFullUrl(apiroot);
            //Console.WriteLine(crypted);
            try
            {
                resp = client.PostAsync(apiurl, new ByteArrayContent(Encoding.UTF8.GetBytes(crypted))).Result;
            }
            catch (Exception e)
            {
                if (dbg) Console.WriteLine($"{LogPrefix} {e}");
                ResetConnection();
                throw;
            }
            PostRequestHeaders();

            var res = resp.Content.ReadAsStringAsync().Result;
            if (resp.StatusCode != HttpStatusCode.OK)
            {
                if (resp.StatusCode == HttpStatusCode.Forbidden) ResetConnection();

                Console.WriteLine($"{LogPrefix} api {apiurl} ret: {resp.StatusCode}");
                throw new Exception();
            }
            
            byte[] decryptedContent;
            
            using (var ms = new MemoryStream())
            {
                var bres = Convert.FromBase64String(res);
                var encryptor = aes.CreateDecryptor(key, iv);
                var content2 = bres[36..];
                using var stream = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
                stream.Write(content2, 0, content2.Length);
                stream.FlushFinalBlock();
                decryptedContent = ms.ToArray();
            }

            var obj = Utils.Unpack(decryptedContent).ToObject<TResult>();

            if (obj.data_headers.result_code == GallopResultCode.BOT_ACCESS_ATTACK_ERROR || obj.data_headers.result_code == GallopResultCode.SESSION_ERROR)
            {
                ResetConnection();
            }

            if (dbg) Console.WriteLine($"{LogPrefix} api {apiurl} ret: {obj.data_headers.result_code}");
            if (dbg) Console.WriteLine(JsonConvert.SerializeObject(obj, Formatting.Indented));

            Account.ViewerId = obj.data_headers.viewer_id;
            if (!string.IsNullOrEmpty(obj.data_headers.sid))
            {
                session_id = Utils.Bin2Hex(Utils.MakeMd5(obj.data_headers.sid));
                if (dbg) Console.WriteLine($"{LogPrefix} sid changed into {session_id}");
            }

            if (obj.data_headers.result_code != GallopResultCode.RESULT_CODE_OK &&
                obj.data_headers.result_code != GallopResultCode.NOTIFY_PREPARATION_SERVICE)
            {
                Console.WriteLine($"{LogPrefix} api {apiurl} ret: result code = {obj.data_headers.result_code}:\n{JsonConvert.SerializeObject(request, Formatting.None)}");
                throw new ApiException(JsonConvert.SerializeObject(request, Formatting.None), JsonConvert.SerializeObject(obj, Formatting.None), obj.data_headers.result_code);
            }

            var commonResp = typeof(TResult).GetField("data").GetValue(obj);
            var tpfield = commonResp?.GetType()?.GetField("tp_info");
            var coinfield = commonResp?.GetType()?.GetField("coin_info");

            if (tpfield != null) tpInfo = tpfield.GetValue(commonResp) as TpInfo;
            if (coinfield != null) FCoin = (coinfield.GetValue(commonResp) as CoinInfo)?.fcoin ?? 0;
            if (obj is IMoneyChange money)
            {
                var money2 = money.current_money;
                if (money2 != null) current_money = (int)money2;
            }

            Interlocked.Increment(ref _reqnum);

            return obj;
        }

        public void Signup()
        {
            ToolSignupResponse resp;
            /*
            do
            {
                try
                {
                    Account.Udid = Guid.NewGuid();
                    if (resp != null && resp.data_headers.result_code == GallopResultCode.RESULT_CODE_OK) break;
                    Thread.Sleep(2000);
                    if (resp?.data_headers?.result_code == GallopResultCode.SAFETYNET_RETRY)
                        Thread.Sleep(8000);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{LogPrefix} {e}");
                }
            } while (true);
            */
            resp = RetryRequest(new ToolSignupRequest
            {
                credential = "",
                error_code = 0,
                error_message = ""
            }, 100);
            Account.Authkey = resp.data.auth_key;
        }

        public void StartSession()
        {
            ToolStartSessionResponse resp = RetryRequest(new ToolStartSessionRequest());
            ResVer = resp.data.resource_version;
        }

        public void ChangeAccount(Account account)
        {
            Account = account;
            session_id = null;
        }


        private LoginResponse userData;
        public LoginResponse Login()
        {
            return userData = RetryRequest(new LoginRequest());
        }

        public PresentReceiveAllResponse.CommonResponse ReceivePresents()
        {
            PresentReceiveAllResponse resp = RetryRequest(new PresentReceiveAllRequest
            {
                category_filter_type = new int[0],
                is_asc = true,
                time_filter_type = 0,
                current_rest_present_num = userData.data.menu_badge_info.present_num ?? 0
            });
            FCoin += resp.data.reward_summary_info?.add_fcoin ?? 0;
            current_money += resp.data.reward_summary_info?.add_item_list?.CalcMoney() ?? 0;
            return resp.data;
        }
        public int Gacha(int gachaId, int draw_num = 10, int item_id = 0, int current_num = 0)
        {
            GachaExecResponse resp = RetryRequest(new GachaExecRequest
            {
                current_num = item_id == 0 ? FCoin : current_num,
                item_id = item_id,
                draw_num = draw_num,
                draw_type = 1,
                gacha_id = gachaId
            });
            if (resp.data.coin_info != null)
                FCoin = resp.data.coin_info.fcoin;
            foreach (RewardAddSupportCardNum card in resp.data.reward_summary_info.add_support_card_num_array)
                if (card.support_card_id >= 30000)
                {
                    if (!Account.extra.support_cards.ContainsKey(card.support_card_id))
                        Account.extra.support_cards[card.support_card_id] = 0;
                    ++Account.extra.support_cards[card.support_card_id];
                }

            return resp.data.limit_item_info.num;
        }

        public void ResetAccount()
        {
            Account = new Account();
            session_id = null;
        }

        public void PublishTransition(string password)
        {
            RetryRequest(new DataLinkPublishTransitionCodeRequest
            {
                password = Utils.Bin2Hex(Utils.MakeMd5(password))
            });
        }
    }
}
