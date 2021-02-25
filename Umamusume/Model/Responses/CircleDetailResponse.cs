

namespace Umamusume.Model
{

	public sealed class CircleDetailResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public CircleInfo circle_info;



			public CircleUser[] circle_user_array;



			public CircleRequest[] circle_request_array;



			public CircleScout[] circle_scout_array;



			public CircleRanking circle_ranking_this_month;



			public CircleRanking circle_ranking_last_month;



			public bool is_calculate;



			public UserInfoAtFriend[] summary_user_info_array;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public CircleDetailResponse()
		{
		}
	}
}
