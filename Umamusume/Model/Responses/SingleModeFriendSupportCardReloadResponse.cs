

namespace Umamusume.Model
{

    public sealed class SingleModeFriendSupportCardReloadResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public UserInfoAtFriend[] summary_user_info_array;



            public UserSupportCard[] support_card_data_array;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public SingleModeFriendSupportCardReloadResponse()
        {
        }
    }
}
