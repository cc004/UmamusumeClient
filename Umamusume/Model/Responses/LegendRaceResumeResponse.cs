

namespace Umamusume.Model
{

	public sealed class LegendRaceResumeResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public RaceHorseData[] race_horse_data_array;



			public int? season;



			public int? weather;



			public int? ground_condition;



			public int? random_seed;



			public int? race_instance_id;



			public string race_scenario;



			public int? state;



			public int? purchase_num;



			public int? is_cleared;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public LegendRaceResumeResponse()
		{
		}
	}
}
