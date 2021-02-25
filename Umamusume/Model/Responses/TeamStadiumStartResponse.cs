

namespace Umamusume.Model
{

	public sealed class TeamStadiumStartResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public int[] use_item_id_array;



			public TeamStadiumRaceStartParams[] race_start_params_array;



			public TeamStadiumRaceResult[] race_result_array;



			public RpInfo rp_info;



			public UserItem[] item_info_array;



			public bool is_include_unsupported_race;



			public TeamStadiumWinningRewardInfo[] winning_reward_info_array;



			public int? winning_reward_guarantee_status;



			public int? last_checked_round;



			public int? support_card_bonus;



			public TeamStadiumTeamData[] user_team_data_array_copy;



			public TrainedChara[] user_trained_chara_array_copy;



			public TeamStadiumOpponent opponent_info_copy;



			public TrainedChara[] opponent_chara_info_array_latest_copy;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public TeamStadiumStartResponse()
		{
		}
	}
}
