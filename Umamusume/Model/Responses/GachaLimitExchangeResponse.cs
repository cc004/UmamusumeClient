

namespace Umamusume.Model
{

    public sealed class GachaLimitExchangeResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public GachaResultData exchange_result;



            public RewardSummaryInfo reward_summary_info;



            public GachaLimitItemInfo limit_item_info;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public GachaLimitExchangeResponse()
        {
        }
    }
}
