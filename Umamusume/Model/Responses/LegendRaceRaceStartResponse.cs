

namespace Umamusume.Model
{

	public sealed class LegendRaceRaceStartResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public string race_scenario;



			public int? state;



			public int? running_style;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public LegendRaceRaceStartResponse()
		{
		}
	}
}
