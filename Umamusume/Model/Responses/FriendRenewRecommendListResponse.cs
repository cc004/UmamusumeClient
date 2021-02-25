

namespace Umamusume.Model
{

	public sealed class FriendRenewRecommendListResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public UserFriend[] recommend_list;



			public UserInfoAtFriend[] user_info_summary_list;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public FriendRenewRecommendListResponse()
		{
		}
	}
}
