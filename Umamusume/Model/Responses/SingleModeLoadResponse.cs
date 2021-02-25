

namespace Umamusume.Model
{

	public sealed class SingleModeLoadResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public SingleModeChara chara_info;



			public SingleModeRaceCondition[] race_condition_array;



			public SingleModeEventInfo[] unchecked_event_array;



			public SingleModeHomeInfo home_info;



			public SingleRaceHistory[] race_history;



			public int[] win_saddle_id_array;



			public SuccessionEffectedFactor[] effected_factor_array;



			public SingleRaceStartInfo race_start_info;



			public string race_scenario;



			public CharaRaceReward race_reward_info;



			public LoginUserTrophyInfo add_trophy_info;



			public RaceRewardData trophy_reward_info;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public SingleModeLoadResponse()
		{
		}
	}
}
