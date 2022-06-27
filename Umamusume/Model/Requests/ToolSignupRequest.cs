namespace Umamusume.Model
{

    public sealed class ToolSignupRequest : RequestBase<ToolSignupResponse>
    {
        public string credential; // 0x68
        public int error_code; // 0x70
        public string error_message; // 0x78
        public string buma_uid; // 0x80
        public string buma_access_token; // 0x88
        public string buma_sdk_udid; // 0x90
        public string buma_login_type; // 0x98

        protected override string Url => "/tool/signup";


        public ToolSignupRequest()
        {
        }
    }
}
