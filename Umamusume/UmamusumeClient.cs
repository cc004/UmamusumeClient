using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
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
        private const string header = "ayDiq2wxEzD3Ydc3zj8wJXUIUGZe6li2Ny+NL1dQHrMSPs9iXuLrJ/WPSNobcJIMw8uazw==";
        private const string appver = "1.2.8";
        private const string apiroot = "https://api-umamusume.cygames.jp/umamusume";
        private const string proxy_server = "127.0.0.1:1080";

        public static int _reqnum = 0;

        public static int Reqnum => Interlocked.Exchange(ref _reqnum, 0);

        public Account Account { get; private set; }
        private HttpClient client = new HttpClient(new HttpClientHandler
        {
            UseProxy = true,
            Proxy = new WebProxy(proxy_server)
        });
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
        private readonly ICryptHandler compressor;

        public UmamusumeClient(ICryptHandler handler) : this(new Account(), handler) { }

        public string LogPrefix;

        private static void AddCommonHeaders(HttpClient client)
        {
            Type headertype = typeof(HttpClient).Assembly.GetType("System.Net.Http.Headers.HttpHeaderType");
            typeof(HttpHeaders).GetField("_allowedHeaderTypes", bindingAttr: BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(client.DefaultRequestHeaders, Enum.Parse(headertype, "All"));
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-msgpack");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "deflate, gzip");
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "UnityPlayer/2019.4.1f1 (UnityWebRequest/1.0, libcurl/7.52.0-DEV)");
            client.DefaultRequestHeaders.TryAddWithoutValidation("X-Unity-Version", "2019.4.1f1");
            client.DefaultRequestHeaders.TryAddWithoutValidation("APP-VER", appver);
            client.DefaultRequestHeaders.TryAddWithoutValidation("RES-VER", "");
        }

        public UmamusumeClient(Account account, ICryptHandler handler)
        {
            compressor = handler;
            Account = account;
            client.DefaultRequestHeaders.Clear();
            client.Timeout = new TimeSpan(0, 0, 30);
            AddCommonHeaders(client);
            ResVer = "10000010";
        }

        private void PreRequestHeaders()
        {
            client.DefaultRequestHeaders.TryAddWithoutValidation("SID", SessionId);
            client.DefaultRequestHeaders.TryAddWithoutValidation("ViewerID", Account.ViewerId.ToString());
        }
        private void PostRequestHeaders()
        {
            client.DefaultRequestHeaders.Remove("SID");
            client.DefaultRequestHeaders.Remove("ViewerID");
        }

        public TResult RetryRequest<TResult>(RequestBase<TResult> request, int count = 3, int interval = 800) where TResult : ResponseCommon
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

        public void ResetConnection()
        {
            Type headertype = typeof(HttpClient).Assembly.GetType("System.Net.Http.Headers.HttpHeaderType");
            HttpClient client = new HttpClient(new HttpClientHandler
            {
                UseProxy = true,
                Proxy = new WebProxy("127.0.0.1:1080")
            });


            typeof(HttpHeaders).GetField("_allowedHeaderTypes", bindingAttr: BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(client.DefaultRequestHeaders, Enum.Parse(headertype, "All"));

            client.DefaultRequestHeaders.Clear();

            foreach (KeyValuePair<string, IEnumerable<string>> header in this.client.DefaultRequestHeaders)
                client.DefaultRequestHeaders.TryAddWithoutValidation(header.Key, header.Value);
            this.client.Dispose();
            this.client = client;
        }

        public TResult Request<TResult>(RequestBase<TResult> request) where TResult : ResponseCommon
        {
            //var arr = CommonHeader.Concat(Utils.Hex2bin(Account.SessionId)).Concat(Account.udid.ToString())
            IEnumerable<byte> head = Convert.FromBase64String(header)
                .Concat(Utils.Hex2bin(SessionId))
                .Concat(Utils.Hex2bin(Account.Udid.ToString().Replace("-", "")))
                .Concat(Utils.GenRandomBytes(32));

            if (Account.Authkey != null) head = head.Concat(Convert.FromBase64String(Account.Authkey));
            request.UpdateInfo(env, Account);
            if (dbg) Console.WriteLine(JsonConvert.SerializeObject(request, Formatting.None));
            byte[] content = Utils.Pack(JToken.FromObject(request));
            byte[] counthead = BitConverter.GetBytes(head.Count());
            string crypted = compressor.Compress(counthead.Concat(head.Concat(content)).ToArray());
            //var crypted = SimpleLz4Frame.Compress(Convert.FromBase64String("XQEAAH50j/tMf5uTRScSC0+C/r4Q9DVfhNNeCVv6Q+boA5swND6hd6/f38nhf/W/vW3aAd9/3uyolZ2GaM1kbGPhWIFCn58eiHIqoH7ctoKMoHvGw2sL8ZtmvbVCbpryiAuTQgrK9R5Bgv3M52rZq+kt8UJf9UJGncP2ed9WQsM/tdQ5SFd+V1oFKV2BDoyxhT585T2RdZrUIBiwelK7MJf2m1VISYgMc8rbCUjOMdAzOo6WlKmuLPMg1+y1FF/gbWD8CczoloK94AeEU11AgFPTe2wSCnEjZmtRsKmDjdBkoePac6t7J7DZFqlpBcgZBimXACzgPIRCRDYph0paprwoYOM4d/LWvOwCkKNS5/6CRVT0opNoCEOTsN4MV/RE7xYf0qRPvz0QADAtLKH5i04baM681PRF45gIaVMnc+kx+7qMCSJvO3HaCcaAbrKp6N3W3IUKZXh1HVddfpp9+5U="));
            PreRequestHeaders();
            HttpResponseMessage resp;
            string apiurl = request.GetFullUrl(apiroot);

            try
            {
                resp = client.PostAsync(apiurl, new ByteArrayContent(Encoding.UTF8.GetBytes(crypted))).Result;
            }
            catch (Exception e)
            {
                if (dbg) Console.WriteLine($"{LogPrefix} {e}");
                throw;
            }
            PostRequestHeaders();
            string res = resp.Content.ReadAsStringAsync().Result;
            if (resp.StatusCode != HttpStatusCode.OK)
            {
                if (resp.StatusCode == HttpStatusCode.Forbidden) ResetConnection();

                Console.WriteLine($"{LogPrefix} api {apiurl} ret: {resp.StatusCode}");
                throw new Exception();
            }

            TResult obj = Utils.Unpack(compressor.Decompress(res)).ToObject<TResult>();

            if (obj.data_headers.result_code == GallopResultCode.BOT_ACCESS_ATTACK_ERROR || obj.data_headers.result_code == GallopResultCode.SESSION_ERROR)
            {
                ResetConnection();
            }

            Account.ViewerId = obj.data_headers.viewer_id;
            if (!string.IsNullOrEmpty(obj.data_headers.sid))
            {
                session_id = Utils.Bin2Hex(Utils.MakeMd5(obj.data_headers.sid));
                if (dbg) Console.WriteLine($"{LogPrefix} sid changed into {session_id}");
            }

            if (obj.data_headers.result_code != GallopResultCode.RESULT_CODE_OK)
            {
                Console.WriteLine($"{LogPrefix} api {apiurl} ret: result code = {obj.data_headers.result_code}:\n{JsonConvert.SerializeObject(request, Formatting.None)}");
                throw new ApiException(JsonConvert.SerializeObject(request, Formatting.None), JsonConvert.SerializeObject(obj, Formatting.None), obj.data_headers.result_code);
            }

            if (dbg) Console.WriteLine($"{LogPrefix} api {apiurl} ret: {obj.data_headers.result_code}");
            if (dbg) Console.WriteLine(JsonConvert.SerializeObject(obj, Formatting.Indented));

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

        public LoginResponse Login()
        {
            return RetryRequest(new LoginRequest());
        }

        public PresentReceiveAllResponse.CommonResponse ReceivePresents()
        {
            PresentReceiveAllResponse resp = RetryRequest(new PresentReceiveAllRequest
            {
                category_filter_type = new int[0],
                is_asc = true,
                time_filter_type = 0
            });
            FCoin += resp.data.reward_summary_info.add_fcoin;
            current_money += resp.data.reward_summary_info.add_item_list.CalcMoney() ?? 0;
            return resp.data;
        }
        public void Gacha(int gachaId, int draw_num = 10, int item_id = 0, int current_num = 0)
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
