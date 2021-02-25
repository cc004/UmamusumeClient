

namespace Umamusume.Model
{

	public sealed class RecoveryTrainerPointResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public CoinInfo coin_info;



			public TpInfo tp_info;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public RecoveryTrainerPointResponse()
		{
		}
	}
}
