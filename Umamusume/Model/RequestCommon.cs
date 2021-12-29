

using Newtonsoft.Json;
using System;

namespace Umamusume.Model
{
    [JsonObject]
    public class RequestEnvironment
    {
        [JsonProperty]
        private int device;



        [JsonProperty]
        private string device_id;


        [JsonProperty]

        private string device_name;


        [JsonProperty]

        private string graphics_device_name;


        [JsonProperty]

        private string ip_address;


        [JsonProperty]

        private string platform_os_version;



        [JsonProperty]
        private string carrier;



        [JsonProperty]
        private int keychain;


        [JsonProperty]
        private string locale;

        [JsonProperty]
        private string dmm_viewer_id;

        [JsonProperty]
        private string dmm_onetime_token;

        protected void UpdateInfo(RequestEnvironment env)
        {
            locale = env.locale;
            keychain = env.keychain;
            carrier = env.carrier;
            platform_os_version = env.platform_os_version;
            ip_address = env.ip_address;
            graphics_device_name = env.graphics_device_name;
            device_name = env.device_name;
            device_id = env.device_id;
            device = env.device;
            dmm_viewer_id = env.dmm_viewer_id;
            dmm_onetime_token = env.dmm_onetime_token;
        }

        public static RequestEnvironment CreateDefault()
        {
            return new()
            {
                platform_os_version = "Android OS 7.1.2 / API-25 (N2G48H/rel.se.infra.20200730.150525)",
                carrier = "OnePlus",
                keychain = 0,
                locale = "JPN",
                ip_address = "10.0.2.15",
                device = 2,
                device_id = Guid.NewGuid().ToString().Replace("-", ""),
                device_name = "OnePlus HD" + new Random().Next(1000, 9999),
                graphics_device_name = "Adreno (TM) 640"
            };
        }
    }

    public class RequestCommon : RequestEnvironment
    {

        [JsonProperty]
        private long viewer_id;


        public RequestCommon()
        {
        }

        public void UpdateInfo(RequestEnvironment env, Account account)
        {
            viewer_id = account.ViewerId;
            UpdateInfo(env);
        }
    }
}
