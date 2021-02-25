

namespace Umamusume.Model
{

	public sealed class SupportCardChangeLockResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public int? support_card_id;



			public int? is_locked;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public SupportCardChangeLockResponse()
		{
		}
	}
}
