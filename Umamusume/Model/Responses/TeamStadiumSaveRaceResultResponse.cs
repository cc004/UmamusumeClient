

namespace Umamusume.Model
{

	public sealed class TeamStadiumSaveRaceResultResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public TeamStadiumRaceResult[] race_result_array;



			public TeamStadiumWinningRewardInfo[] winning_reward_info_array;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public TeamStadiumSaveRaceResultResponse()
		{
		}
	}
}
