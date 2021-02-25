

namespace Umamusume.Model
{

	public sealed class ReadInfoResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public HomeStoryDataForDisplay[] home_story_data_array;



			public ShortEpisodeDataForDisplay[] short_episode_data_array;



			public HomePosterDataForDisplay[] home_poster_data_array;



			public TutorialGuideDataForDisplay[] tutorial_guide_data_array;



			public ReleasedEpisodeDataForDisplay[] released_episode_data_array;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public ReadInfoResponse()
		{
		}
	}
}
