

namespace Umamusume.Model
{

    public sealed class SupportCardStrengthenResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public UserSupportCard support_card_data;



            public UserItem[] item_data_array;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public SupportCardStrengthenResponse()
        {
        }
    }
}
