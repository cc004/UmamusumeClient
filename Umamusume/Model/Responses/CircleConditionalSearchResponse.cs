

namespace Umamusume.Model
{

    public sealed class CircleConditionalSearchResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public CircleInfo[] circle_info_array;



            public UserInfoAtFriend[] leader_info_array;



            public CircleRanking[] circle_ranking_array;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public CircleConditionalSearchResponse()
        {
        }
    }
}
