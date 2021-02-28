

namespace Umamusume.Model
{

    public sealed class CircleChatSendItemRequestResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public CircleChatMessage[] circle_chat_message_array;



            public CircleChatUser[] circle_chat_user_array;



            public CircleItemRequest[] circle_item_request_array;



            public CircleItemDonate[] circle_item_donate_array;







            public string item_request_end_time;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public CircleChatSendItemRequestResponse()
        {
        }
    }
}
