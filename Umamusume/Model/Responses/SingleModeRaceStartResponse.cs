

namespace Umamusume.Model
{

	public sealed class SingleModeRaceStartResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public SingleRaceStartInfo race_start_info;



			public string race_scenario;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public SingleModeRaceStartResponse()
		{
		}
	}
}
