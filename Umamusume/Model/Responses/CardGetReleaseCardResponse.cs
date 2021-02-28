

namespace Umamusume.Model
{

    public sealed class CardGetReleaseCardResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public int[] release_card_array;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public CardGetReleaseCardResponse()
        {
        }
    }
}
