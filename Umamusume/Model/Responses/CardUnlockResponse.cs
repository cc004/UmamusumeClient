

namespace Umamusume.Model
{

	public sealed class CardUnlockResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public RewardSummaryInfo reward_summary_info;



			public PieceData[] piece_data;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public CardUnlockResponse()
		{
		}
	}
}
