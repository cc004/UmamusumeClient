

namespace Umamusume.Model
{

    public sealed class CircleItemRequestReceiveResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public CircleItemDonate[] circle_item_donate_array;



            public CircleChatUser[] circle_chat_user_array;



            public RewardSummaryInfo reward_summary_info;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public CircleItemRequestReceiveResponse()
        {
        }
    }
}
