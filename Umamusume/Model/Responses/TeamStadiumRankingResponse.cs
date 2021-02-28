

namespace Umamusume.Model
{

    public sealed class TeamStadiumRankingResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public TeamStadiumRanking[] ranking_array;



            public UserInfoAtFriend[] summary_user_info_array;



            public UserFriend[] user_friend_array;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public TeamStadiumRankingResponse()
        {
        }
    }
}
