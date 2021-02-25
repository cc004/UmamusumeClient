

namespace Umamusume.Model
{

	public sealed class PresentIndexResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public PresentData[] present_array;



			public NoReceivePresentNum no_receive_present_num;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public PresentIndexResponse()
		{
		}
	}
}
