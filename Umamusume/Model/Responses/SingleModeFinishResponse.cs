

namespace Umamusume.Model
{

    public sealed class SingleModeFinishResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public TrainedChara[] trained_chara;



            public DirectoryCard[] directory_card_array;



            public int? directory_ranking;



            public int? trained_chara_id;



            public SingleModeChara chara_info;



            public LovePointInfo love_point_info;



            public RewardSummaryInfo reward_item_info;



            public UserSupportCard[] support_card_data_array;



            public LimitedShopInfo limited_shop_info;



            public UserChara update_user_chara_info;



            public int? release_item_flag;



            public ulong? circle_point;



            public CharaProfileData[] new_chara_profile_array;



            public int[] campaign_id_array;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public SingleModeFinishResponse()
        {
        }
    }
}
