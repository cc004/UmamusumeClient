

namespace Umamusume.Model
{

    public sealed class SupportCardDeckChangePartyResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public UserSupportCardDeck[] support_card_deck_array;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public SupportCardDeckChangePartyResponse()
        {
        }
    }
}
