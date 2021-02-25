

namespace Umamusume.Model
{

	public sealed class RecoveryRacePointResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public CoinInfo coin_info;



			public RpInfo rp_info;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public RecoveryRacePointResponse()
		{
		}
	}
}
