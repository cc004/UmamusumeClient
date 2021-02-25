

namespace Umamusume.Model
{

	public sealed class PaymentGetCoinBreakDownInfoResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public PaymentCoinBreakDownInfo[] coin_break_down_info_array;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public PaymentGetCoinBreakDownInfoResponse()
		{
		}
	}
}
