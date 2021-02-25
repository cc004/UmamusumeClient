using System;



namespace Umamusume.Model
{

	public sealed class MainStoryRaceRaceStartRequest : RequestBase<MainStoryRaceRaceStartResponse>
	{


		public int? episode_id;



		public int? trained_chara_id;



		public int? running_style;



		


		public MainStoryRaceRaceStartRequest()
		{
		}
	}
}
