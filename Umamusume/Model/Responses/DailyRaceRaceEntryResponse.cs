

namespace Umamusume.Model
{

	public sealed class DailyRaceRaceEntryResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public RaceHorseData[] race_horse_data_array;



			public int? season;



			public int? weather;



			public int? ground_condition;



			public int? random_seed;



			public int? race_instance_id;



			public int? state;



			public int? trained_chara_id;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public DailyRaceRaceEntryResponse()
		{
		}
	}
}
