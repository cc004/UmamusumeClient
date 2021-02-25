

namespace Umamusume.Model
{

	public sealed class RaceAnalyzeResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public RaceHorseData[] race_horse_data_array;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public RaceAnalyzeResponse()
		{
		}
	}
}
