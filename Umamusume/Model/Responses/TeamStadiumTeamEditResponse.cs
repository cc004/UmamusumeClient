

namespace Umamusume.Model
{

	public sealed class TeamStadiumTeamEditResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public DisplayRewardInfo[] reward_info_array;



			public int? before_rank;



			public int? after_rank;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public TeamStadiumTeamEditResponse()
		{
		}
	}
}
