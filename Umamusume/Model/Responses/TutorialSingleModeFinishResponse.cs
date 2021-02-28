

namespace Umamusume.Model
{

    public sealed class TutorialSingleModeFinishResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public TrainedChara[] trained_chara;



            public DirectoryCard[] directory_card_array;



            public int? directory_ranking;



            public int? trained_chara_id;



            public LovePointInfo love_point_info;



            public RewardSummaryInfo reward_item_info;



            public UserSupportCard[] support_card_data_array;



            public LimitedShopInfo limited_shop_info;



            public UserChara update_user_chara_info;



            public CharaProfileData[] new_chara_profile_array;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public TutorialSingleModeFinishResponse()
        {
        }
    }
}
