

namespace Umamusume.Model
{

	public sealed class DailyRaceIndexResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public DailyRaceData[] daily_race_record_array;



			public int? purchase_num;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public DailyRaceIndexResponse()
		{
		}
	}
}
