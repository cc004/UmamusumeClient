

namespace Umamusume.Model
{

    public sealed class DataLinkGetByTransitionCodeResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public int? target_viewer_id;



            public string name;



            public string request_user_name;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public DataLinkGetByTransitionCodeResponse()
        {
        }
    }
}
