

namespace Umamusume.Model
{

	public sealed class SingleModeRaceEndResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public CharaRaceReward race_reward_info;



			public SingleModeChara chara_info;



			public SingleModeHomeInfo home_info;



			public UserMusic add_music;



			public SingleRaceHistory[] race_history;



			public int[] win_saddle_id_array;



			public SingleModeRaceCondition[] race_condition_array;



			public LoginUserTrophyInfo add_trophy_info;



			public RaceRewardData trophy_reward_info;



			public RewardSummaryInfo reward_summary_info;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public SingleModeRaceEndResponse()
		{
		}
	}
}
