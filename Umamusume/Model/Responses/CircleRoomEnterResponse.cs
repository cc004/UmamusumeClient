

namespace Umamusume.Model
{

    public sealed class CircleRoomEnterResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public CircleInfo circle_info;



            public CircleUser[] circle_user_array;



            public UserInfoAtFriend[] summary_user_info_array;



            public bool change_leader;



            public bool is_scout_able;



            public bool is_show_ranking_result;



            public CircleChatMessage[] circle_chat_message_array;



            public CircleItemRequest[] circle_item_request_array;



            public CircleItemDonate[] circle_item_donate_array;



            public CircleRanking circle_ranking_this_month;



            public CircleRanking circle_ranking_last_month;



            public bool is_calculate;







            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public CircleRoomEnterResponse()
        {
        }
    }
}
