

namespace Umamusume.Model
{

    public sealed class TeamStadiumIndexResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public int? team_stadium_id;



            public TeamStadiumUser team_stadium_user;



            public TeamStadiumRanking ranking;



            public TeamStadiumBorderLine border_line;



            public int? team_class_change_state;



            public DisplayRewardInfo[] reward_info_array;



            public int? race_status;



            public int? term_state;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public TeamStadiumIndexResponse()
        {
        }
    }
}
