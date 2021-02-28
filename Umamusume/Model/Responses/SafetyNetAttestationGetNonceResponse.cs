

namespace Umamusume.Model
{

    public sealed class SafetyNetAttestationGetNonceResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public int? can_use;



            public string nonce;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public SafetyNetAttestationGetNonceResponse()
        {
        }
    }
}
