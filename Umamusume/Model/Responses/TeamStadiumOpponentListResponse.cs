

namespace Umamusume.Model
{

	public sealed class TeamStadiumOpponentListResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public TeamStadiumOpponent[] opponent_info_array;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public TeamStadiumOpponentListResponse()
		{
		}
	}
}
