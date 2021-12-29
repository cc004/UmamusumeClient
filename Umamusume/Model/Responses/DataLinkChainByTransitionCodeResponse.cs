

namespace Umamusume.Model
{

    public sealed class DataLinkChainByTransitionCodeResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public long? chained_viewer_id;



            public string chained_user_name;



            public string auth_key;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public DataLinkChainByTransitionCodeResponse()
        {
        }
    }
}
