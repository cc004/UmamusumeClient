

namespace Umamusume.Model
{

	public sealed class LegendRaceIndexResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public LegendRaceData[] legend_race_record_array;



			public int? purchase_num;



			public UserItem[] update_item_array;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public LegendRaceIndexResponse()
		{
		}
	}
}
