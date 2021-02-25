

namespace Umamusume.Model
{

	public sealed class PresentReceiveResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public RewardSummaryInfo reward_summary_info;



			public int? receive_present_num;



			public int? rest_present_num;



			public int? no_receive_support_card_count;



			public bool no_receive_item_flg;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public PresentReceiveResponse()
		{
		}
	}
}
