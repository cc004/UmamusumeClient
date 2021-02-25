

namespace Umamusume.Model
{

	public sealed class DailyRaceReplayCheckResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public int? rank;



			public RaceRewardData[] first_clear_reward_array;



			public RaceRewardData[] normal_reward_array;



			public RaceRewardData[] rare_reward_array;



			public RewardSummaryInfo reward_summary_info;



			public int? state;



			public LimitedShopInfo limited_shop_info;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public DailyRaceReplayCheckResponse()
		{
		}
	}
}
