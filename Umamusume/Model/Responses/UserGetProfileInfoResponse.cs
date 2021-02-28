

namespace Umamusume.Model
{

    public sealed class UserGetProfileInfoResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public int? voice_num;



            public int? act_num;



            public int? good_end_num;



            public int? team_stadium_win_count;



            public int? single_mode_play_count;



            public int? rank_score;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public UserGetProfileInfoResponse()
        {
        }
    }
}
