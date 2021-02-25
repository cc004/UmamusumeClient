

namespace Umamusume.Model
{

	public sealed class FriendLoadResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public UserFriend[] friend_list;



			public UserFriend[] recommend_list;



			public UserInfoAtFriend[] user_info_summary_list;



			public UserInfoAtFollower[] follower_info_summary_list;



			public string last_friend_checked_time;



			public int? follower_num;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public FriendLoadResponse()
		{
		}
	}
}
