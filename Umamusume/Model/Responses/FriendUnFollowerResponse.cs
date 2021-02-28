

namespace Umamusume.Model
{

    public sealed class FriendUnFollowerResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public UserFriend friend_data;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public FriendUnFollowerResponse()
        {
        }
    }
}
