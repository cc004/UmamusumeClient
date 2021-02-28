

namespace Umamusume.Model
{

    public sealed class GetTrophyInfoResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public UserTrophyInfo[] user_trophy_info_array;



            public long last_checked_time;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public GetTrophyInfoResponse()
        {
        }
    }
}
