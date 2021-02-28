namespace Umamusume.Model
{

    public sealed class SafetyNetAttestationValidateJwsRequest : RequestBase<SafetyNetAttestationValidateJwsResponse>
    {


        public string jws;



        public int? error_code;



        public string error_message;






        public SafetyNetAttestationValidateJwsRequest()
        {
        }
    }
}
