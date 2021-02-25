using System;



namespace Umamusume.Model
{

	public sealed class DebugRaceSimulateRequest : RequestBase<DebugRaceSimulateResponse>
	{


		public string simulator_version;



		public string simulate_resource_version;



		public int? race_instance_id;



		public int? random_seed;



		public int? season;



		public int? weather;



		public int? ground_condition;



		public RaceHorseData[] race_horse_data;



		public int? race_type;



		public int? self_evaluate;



		public int? opponent_evaluate;



		public int? score_calc_team_id;



		public int? win_count;



		public int? support_card_bonus;



		


		public DebugRaceSimulateRequest()
		{
		}
	}
}
