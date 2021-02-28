

namespace Umamusume.Model
{

    public sealed class GachaGetPrizeHistoryResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public GachaPrizeHistory[] prize_history_array;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public GachaGetPrizeHistoryResponse()
        {
        }
    }
}
