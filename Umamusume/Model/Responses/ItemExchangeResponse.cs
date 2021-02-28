

namespace Umamusume.Model
{

    public sealed class ItemExchangeResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public RewardSummaryInfo reward_summary_info;



            public CoinInfo coin_info;



            public UserItem use_item_info;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public ItemExchangeResponse()
        {
        }
    }
}
