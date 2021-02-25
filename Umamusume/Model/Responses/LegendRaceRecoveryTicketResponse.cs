

namespace Umamusume.Model
{

	public sealed class LegendRaceRecoveryTicketResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public CoinInfo coin_info;



			public RewardSummaryInfo reward_summary_info;



			public int? purchase_num;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public LegendRaceRecoveryTicketResponse()
		{
		}
	}
}
