using System;



namespace Umamusume.Model
{

	public sealed class ReadInfoRequest : RequestBase<ReadInfoResponse>
	{


		public HomeStoryDataForRegist[] add_home_story_data_array;



		public ShortEpisodeDataForRegist[] add_short_episode_data_array;



		public HomePosterDataForRegist[] add_home_poster_data_array;



		public TutorialGuideDataForRegist[] add_tutorial_guide_data_array;



		public ReleasedEpisodeDataForRegist[] add_released_episode_data_array;



		


		public ReadInfoRequest()
		{
		}
	}
}
