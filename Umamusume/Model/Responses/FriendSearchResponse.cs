

namespace Umamusume.Model
{

    public sealed class FriendSearchResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public UserFriend friend_info;



            public UserInfoAtFriend user_info_summary;



            public TrainedChara practice_partner_info;



            public TrainedChara[] directory_chara_info;



            public DirectoryCard[] directory_card_array;



            public UserSupportCard support_card_data;



            public TrophyNumInfo trophy_num_info;



            public ReleaseNumInfo release_num_info;



            public TeamStadiumUser team_stadium_user;



            public int? follower_num;



            public int? own_follow_num;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public FriendSearchResponse()
        {
        }
    }
}
