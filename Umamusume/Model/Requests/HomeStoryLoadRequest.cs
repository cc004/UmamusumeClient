using System;



namespace Umamusume.Model
{

	public sealed class HomeStoryLoadRequest : RequestBase<HomeStoryLoadResponse>
	{


		public HomeStoryDataForRegist[] add_home_story_data_array;



		


		public HomeStoryLoadRequest()
		{
		}
	}
}
