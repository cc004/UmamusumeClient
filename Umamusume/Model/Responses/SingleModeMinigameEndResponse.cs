

namespace Umamusume.Model
{

	public sealed class SingleModeMinigameEndResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public SingleModeChara chara_info;



			public SingleModeEventInfo[] unchecked_event_array;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public SingleModeMinigameEndResponse()
		{
		}
	}
}
