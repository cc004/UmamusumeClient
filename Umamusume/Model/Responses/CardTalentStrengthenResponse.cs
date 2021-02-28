

namespace Umamusume.Model
{

    public sealed class CardTalentStrengthenResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public UserCard card_data;



            public UserItem[] item_data_array;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public CardTalentStrengthenResponse()
        {
        }
    }
}
