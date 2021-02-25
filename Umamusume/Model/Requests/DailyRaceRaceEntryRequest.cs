using System;



namespace Umamusume.Model
{

	public sealed class DailyRaceRaceEntryRequest : RequestBase<DailyRaceRaceEntryResponse>
	{


		public int? daily_race_id;



		public int? trained_chara_id;



		


		public DailyRaceRaceEntryRequest()
		{
		}
	}
}
