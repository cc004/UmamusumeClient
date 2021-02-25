

namespace Umamusume.Model
{

	public sealed class SingleModeRaceEntryResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public SingleModeChara chara_info;



			public SingleModeHomeInfo home_info;



			public SingleRaceStartInfo race_start_info;



			public SingleModeEventInfo[] unchecked_event_array;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public SingleModeRaceEntryResponse()
		{
		}
	}
}
