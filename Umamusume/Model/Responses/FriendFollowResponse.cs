

namespace Umamusume.Model
{

    public sealed class FriendFollowResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public UserFriend friend_data;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public FriendFollowResponse()
        {
        }
    }
}
