namespace Umamusume.Model
{

    public sealed class ToolDeviceAttestRequest : RequestBase<ToolDeviceAttestResponse>
    {


        public string credential;



        public int? error_code;



        public string error_message;






        public ToolDeviceAttestRequest()
        {
        }
    }
}
