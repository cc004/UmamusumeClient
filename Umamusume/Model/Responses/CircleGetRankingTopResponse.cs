

namespace Umamusume.Model
{

	public sealed class CircleGetRankingTopResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public CircleInfo[] circle_info_array;



			public UserInfoAtFriend[] leader_info_array;



			public CircleRanking[] circle_ranking_array;



			public bool is_calculate;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public CircleGetRankingTopResponse()
		{
		}
	}
}
