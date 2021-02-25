

namespace Umamusume.Model
{

	public sealed class HomeStoryLoadResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public HomeStoryDataForDisplay[] home_story_data_array;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public HomeStoryLoadResponse()
		{
		}
	}
}
