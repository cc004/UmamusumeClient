

namespace Umamusume.Model
{

    public sealed class DataLinkGetGameDataBySocialAccountResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public int? viewer_id;



            public string name;



            public int? is_chained;



            public string request_user_name;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public DataLinkGetGameDataBySocialAccountResponse()
        {
        }
    }
}
