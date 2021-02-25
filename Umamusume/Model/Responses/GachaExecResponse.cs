

namespace Umamusume.Model
{

	public sealed class GachaExecResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public GachaResultData[] gacha_result_list;



			public ResponseItem[] bonus_item_array;



			public CoinInfo coin_info;



			public RewardSummaryInfo reward_summary_info;



			public ResponseItem[] item_list;



			public GachaLimitItemInfo limit_item_info;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public GachaExecResponse()
		{
		}
	}
}
