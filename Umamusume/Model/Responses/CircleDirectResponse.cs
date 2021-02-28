

namespace Umamusume.Model
{

    public sealed class CircleDirectResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public DisplayRewardInfo[] reward_info_array;



            public int? after_rank;



            public int? best_team_evaluation_point;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public CircleDirectResponse()
        {
        }
    }
}
