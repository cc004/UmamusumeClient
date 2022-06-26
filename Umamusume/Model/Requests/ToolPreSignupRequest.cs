using System;

namespace Umamusume.Model
{


    // Namespace: Gallop
    public class ToolPreSignupInfo_BUMA // TypeDefIndex: 14418
    {
        // Fields
        public int load_name; // 0x10
        public int load_time; // 0x14
        public string load_date; // 0x18
    }

    public sealed class ToolPreSignupRequest : RequestBase<ToolPreSignupResponse>
    {
        protected override string Url => "/tool/pre_signup";

        public ToolPreSignupInfo_BUMA[] pre_step_info; // 0x68


        public ToolPreSignupRequest()
        {
            const string fmt = "yyyy-MM-ddThh:mm:ss";
            var rnd = new Random();
            var td = DateTime.Now;
            pre_step_info = new ToolPreSignupInfo_BUMA[3]
            {
                new()
                {
                    load_date = td.AddSeconds(-rnd.Next(9, 11)).ToString(fmt), load_name = 0,
                    load_time = rnd.Next(450, 500)
                },
                new()
                {
                    load_date = td.AddSeconds(-rnd.Next(5, 6)).ToString(fmt), load_name = 0,
                    load_time = rnd.Next(800, 900)
                },
                new()
                {
                    load_date = td.AddSeconds(-rnd.Next(3, 4)).ToString(fmt), load_name = 0,
                    load_time = rnd.Next(200, 300)
                },
            };
        }
    }

    public class BumaToolServerlistResponse : ResponseCommon
    {

        public class CommonResponse
        {
            public string[] buma_api_servers; // 0x10
            public string[] buma_resource_servers; // 0x18

            public CommonResponse()
            {
            }
        }

        public CommonResponse data;
    }

    public sealed class BumaToolServerlistRequest : RequestBase<BumaToolServerlistResponse>
    {
        protected override string Url => "/buma_tool/server_list";
        
    }
}
