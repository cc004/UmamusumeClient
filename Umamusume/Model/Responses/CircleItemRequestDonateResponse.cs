

namespace Umamusume.Model
{

	public sealed class CircleItemRequestDonateResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public CircleItemDonate[] circle_item_donate_array;



			public RewardSummaryInfo reward_summary_info;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public CircleItemRequestDonateResponse()
		{
		}
	}
}
