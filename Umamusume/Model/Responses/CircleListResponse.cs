

namespace Umamusume.Model
{

    public sealed class CircleListResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public int[] recommend_circle_id_array;



            public CircleRequest circle_request;



            public CircleScout[] circle_scout_array;



            public CircleInfo[] circle_info_array;



            public UserInfoAtFriend[] leader_info_array;



            public CircleRanking[] circle_ranking_array;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public CircleListResponse()
        {
        }
    }
}
