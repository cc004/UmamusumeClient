﻿using Newtonsoft.Json;
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
using System.Threading.Tasks;
using Umamusume.Data;
using Umamusume.Model;

namespace Umamusume
{

    public class UmamusumeClient
    {
        private static Dictionary<int, string> suuport_name_cache = new Dictionary<int, string>();

        static UmamusumeClient()
        {
            suuport_name_cache = CsvManager.LoadData<CsvTextData>().Where(text => text.category == 75)
                .ToDictionary(text => text.index, text => text.text);
        }

        private static readonly byte[] CommonHeader = Convert.FromBase64String("ayDiq2wxEzD3Ydc3zj8wJXUIUGZe6li2Ny+NL1dQHrMYsUuX4Hfvd1m/0/YcBUjjvl2MLQ==");

        private const string apiroot = "https://api-umamusume.cygames.jp/umamusume";

        public Account Account { get; private set; }
        private HttpClient client = new HttpClient(new HttpClientHandler
        {
            UseProxy = true,
            Proxy = new WebProxy("127.0.0.1:1080")
        });
        public RequestEnvironment env = RequestEnvironment.CreateDefault();

        private string resver;

        public int FCoin { get; private set; }

        public string ResVer
        {
            get => resver;
            private set
            {
                resver = value;
                Console.WriteLine($"resver changed into {resver}");
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
            var headertype = typeof(HttpClient).Assembly.GetType("System.Net.Http.Headers.HttpHeaderType");
            typeof(HttpHeaders).GetField("_allowedHeaderTypes", bindingAttr: BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(client.DefaultRequestHeaders, Enum.Parse(headertype, "All"));
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-msgpack");

            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "deflate, gzip");
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "UnityPlayer/2019.4.1f1 (UnityWebRequest/1.0, libcurl/7.52.0-DEV)");
            client.DefaultRequestHeaders.TryAddWithoutValidation("X-Unity-Version", "2019.4.1f1");
            client.DefaultRequestHeaders.TryAddWithoutValidation("APP-VER", "1.0.2");
            client.DefaultRequestHeaders.TryAddWithoutValidation("RES-VER", "");


        }

        public UmamusumeClient(Account account, ICryptHandler handler)
        {
            compressor = handler;
            Account = account;
            client.DefaultRequestHeaders.Clear();
            client.Timeout = new TimeSpan(0, 0, 5);
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

        public TResult RetryRequest<TResult>(RequestBase<TResult> request, int count = 3, int interval = 1000) where TResult : ResponseCommon
        {
            TResult result = null;
            for (int i = 0; i < count; ++i)
            {
                result = Request(request);
                if (result != null) return result;
                Thread.Sleep(interval);
            }
            return result;
        }
        public TResult Request<TResult>(RequestBase<TResult> request) where TResult : ResponseCommon
        {
            //var arr = CommonHeader.Concat(Utils.Hex2bin(Account.SessionId)).Concat(Account.udid.ToString())
            var head = CommonHeader
                .Concat(Utils.Hex2bin(SessionId))
                .Concat(Utils.Hex2bin(Account.Udid.ToString().Replace("-", "")))
                .Concat(Utils.GenRandomBytes(32));

            if (Account.Authkey != null) head = head.Concat(Convert.FromBase64String(Account.Authkey));
            request.UpdateInfo(env, Account);
            //Console.WriteLine(JsonConvert.SerializeObject(request, Formatting.None));
            var content = Utils.Pack(JToken.FromObject(request));
            var counthead = BitConverter.GetBytes(head.Count());
            var crypted = compressor.Compress(counthead.Concat(head.Concat(content)).ToArray());
            //var crypted = SimpleLz4Frame.Compress(Convert.FromBase64String("XQEAAH50j/tMf5uTRScSC0+C/r4Q9DVfhNNeCVv6Q+boA5swND6hd6/f38nhf/W/vW3aAd9/3uyolZ2GaM1kbGPhWIFCn58eiHIqoH7ctoKMoHvGw2sL8ZtmvbVCbpryiAuTQgrK9R5Bgv3M52rZq+kt8UJf9UJGncP2ed9WQsM/tdQ5SFd+V1oFKV2BDoyxhT585T2RdZrUIBiwelK7MJf2m1VISYgMc8rbCUjOMdAzOo6WlKmuLPMg1+y1FF/gbWD8CczoloK94AeEU11AgFPTe2wSCnEjZmtRsKmDjdBkoePac6t7J7DZFqlpBcgZBimXACzgPIRCRDYph0paprwoYOM4d/LWvOwCkKNS5/6CRVT0opNoCEOTsN4MV/RE7xYf0qRPvz0QADAtLKH5i04baM681PRF45gIaVMnc+kx+7qMCSJvO3HaCcaAbrKp6N3W3IUKZXh1HVddfpp9+5U="));
            PreRequestHeaders();
            HttpResponseMessage resp;
            var apiurl = request.GetFullUrl(apiroot);

            try
            {
                resp = client.PostAsync(apiurl, new ByteArrayContent(Encoding.UTF8.GetBytes(crypted))).Result;
            }
            catch (Exception e)
            {
                Console.WriteLine($"{LogPrefix} {e}");
                return null;
            }
            PostRequestHeaders();
            var res = resp.Content.ReadAsStringAsync().Result;
            if (resp.StatusCode != HttpStatusCode.OK)
            {
                Console.WriteLine($"{LogPrefix} api {apiurl} ret: {resp.StatusCode}");
                return null;
            }

            var obj = Utils.Unpack(compressor.Decompress(res)).ToObject<TResult>();

            Console.WriteLine($"{LogPrefix} api {apiurl} ret: result code = {obj.data_headers.result_code}");

            Account.ViewerId = obj.data_headers.viewer_id;
            if (!string.IsNullOrEmpty(obj.data_headers.sid))
            {
                session_id = Utils.Bin2Hex(Utils.MakeMd5(obj.data_headers.sid));
                //Console.WriteLine($"sid changed into {session_id}");
            }
            //Console.WriteLine($"api ret:\n {obj}");
            //Console.WriteLine(JsonConvert.SerializeObject(obj, Formatting.None));
            return obj;
        }

        public void Signup()
        {
            ToolSignupResponse resp;
            do
            {
                try
                {
                    Account.Udid = Guid.NewGuid();
                    resp = Request(new ToolSignupRequest
                    {
                        credential = "",
                        error_code = 0,
                        error_message = "TimeOut Error: Timed out waiting for Task"
                    });
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

            Account.Authkey = resp.data.auth_key;
        }

        public void StartSession()
        {
            var resp = RetryRequest(new ToolStartSessionRequest());
            ResVer = resp.data.resource_version;
        }

        public void Login()
        {
            var resp = RetryRequest(new LoginRequest());
            if (resp.data.coin_info != null)
                FCoin = resp.data.coin_info.fcoin;
        }

        public void ReceivePresents()
        {
            var resp = RetryRequest(new PresentReceiveAllRequest
            {
                category_filter_type = new int[0],
                is_asc = true,
                time_filter_type = 0
            });
            FCoin += resp.data.reward_summary_info.add_fcoin;
        }

        public void Gacha(int gachaId)
        {
            var resp = RetryRequest(new GachaExecRequest
            {
                current_num = FCoin,
                item_id = 0,
                draw_num = 10,
                draw_type = 1,
                gacha_id = gachaId
            });
            FCoin = resp.data.coin_info.fcoin;
            foreach (var card in resp.data.reward_summary_info.add_support_card_num_array)
                if (card.support_card_id >= 30000)
                    Account.extra.support_cards.Add(suuport_name_cache[card.support_card_id]);
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