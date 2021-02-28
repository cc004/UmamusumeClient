

namespace Umamusume.Model
{

    public sealed class LegendRaceReplayCheckResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public int? rank;



            public RaceRewardData[] first_clear_reward_array;



            public RaceRewardData[] drop_reward_array;



            public RaceRewardData[] victory_reward_array;



            public RewardSummaryInfo reward_summary_info;



            public int? state;



            public LoginUserTrophyInfo add_trophy_info;



            public RaceRewardData trophy_reward_info;



            public LimitedShopInfo limited_shop_info;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public LegendRaceReplayCheckResponse()
        {
        }
    }
}
