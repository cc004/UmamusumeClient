

namespace Umamusume.Model
{

	public sealed class SupportCardSellResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public RewardSummaryInfo reward_summary_info;



			public DisplayRewardInfo[] reward_info_array;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public SupportCardSellResponse()
		{
		}
	}
}
