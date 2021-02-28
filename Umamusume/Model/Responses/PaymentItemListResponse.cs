

namespace Umamusume.Model
{

    public sealed class PaymentItemListResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public PaymentPurchaseItemParam[] data;



            public PaymentSeasonPackInfo season_pack_info;



            public int? last_checked_time;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public PaymentItemListResponse()
        {
        }
    }
}
