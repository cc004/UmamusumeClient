

namespace Umamusume.Model
{

	public sealed class TeamStadiumAllRaceEndResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public int? add_friend_point;



			public TeamStadiumAddFanInfo[] add_fan_info_array;



			public int? add_love_point;



			public UserChara[] update_user_chara_array;



			public RewardSummaryInfo reward_summary_info;



			public TeamStadiumWinningRewardContent[] winning_reward_content_array;



			public TeamStadiumTotalScoreInfo total_score_info;



			public int? final_win_type;



			public int? is_update_high_score;



			public int? ranking_rank;



			public int? mvp_chara_id;



			public LimitedShopInfo limited_shop_info;



			public ulong circle_point;



			public CharaProfileData[] new_chara_profile_array;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public TeamStadiumAllRaceEndResponse()
		{
		}
	}
}
