

namespace Umamusume.Model
{

	public sealed class PaymentFinishResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public bool first_time;



			public PaymentPurchaseTimesData purchased_times_data;



			public string purchase_id;



			public int? before_paid_coin;



			public int? before_free_coin;



			public int? after_paid_coin;



			public int? after_free_coin;



			public PaymentSeasonPackInfo season_pack_info;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public PaymentFinishResponse()
		{
		}
	}
}
