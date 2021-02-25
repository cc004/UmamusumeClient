

namespace Umamusume.Model
{

	public sealed class TeamStadiumUserDetailResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public TeamStadiumTeamData[] team_data_array;



			public TrainedChara[] trained_chara_array;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public TeamStadiumUserDetailResponse()
		{
		}
	}
}
