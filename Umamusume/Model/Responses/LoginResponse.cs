

namespace Umamusume.Model
{

    public sealed class LoginResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public CommonDefine common_define;



            public UserInfo user_info;



            public CoinInfo coin_info;



            public TrainedChara[] trained_chara;



            public UserChara[] chara_list;



            public UserCard[] card_list;



            public UserSupportCard[] support_card_list;



            public UserSupportCardDeck[] support_card_deck_array;



            public UserItem[] item_list;



            public PieceData[] piece_list;



            public UserCloth[] cloth_list;



            public UserMusic[] music_list;



            public string res_version;



            //public TpInfo tp_info;



            public RpInfo rp_info;



            public GachaBannerInfo[] gacha_banner_info;



            public GachaCampaignInfo[] gacha_campaign_info_array;



            public LastCheckedTime[] user_last_checked_time_list;



            public MenuBadgeInfo menu_badge_info;



            public PaymentPurchasedTimes[] payment_purchased_times_list;



            public string user_birth;



            public MainStoryData[] main_story_data_list;



            public CharacterStoryData[] character_story_data_list;



            public CircleAtLoad circle_data;



            public SingleModeCharaLight single_mode_chara_light;



            public HomeCharacterDressInfo home_position_info;



            public int? is_linkage;



            public PaymentSeasonPackInfo season_pack_info;



            public NoteDataForDisplay[] event_data_array;



            public CharaProfileData[] chara_profile_array;



            public LoginBonusData[] login_bonus_list;



            public TeamStadiumTeamData[] team_data_array;



            public DirectoryCard[] directory_card_array;



            public int? add_friend_point;



            public int? support_user_num;



            public TeamStadiumUser team_stadium_user;



            public DailyRacePlayingInfo daily_race_playing_info;



            public LegendRacePlayingInfo legend_race_playing_info;



            public int[] single_mode_scenario_id_array;



            public int? single_mode_rental_succession_num;



            public HonorInfo honor_info;



            public LoginUserTrophyInfo[] login_trophy_info_array;



            public int? team_stadium_race_status;



            public LimitedShopInfo limited_shop_info;



            public int? release_item_flag;



            public HomeStoryDataForDisplay[] home_story_data_array;



            public ShortEpisodeDataForDisplay[] short_episode_data_array;



            public HomePosterDataForDisplay[] home_poster_data_array;



            public TeamStadiumRanking ranking;



            public TeamStadiumBorderLine border_line;



            public TutorialGuideDataForDisplay[] tutorial_guide_data_array;



            public string last_information_update_time;



            public int[] release_card_array;



            public int[] unread_announce_id_array;



            public ReleasedEpisodeDataForDisplay[] released_episode_data_array;



            public int[] stadium_race_chara_id_array;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public LoginResponse()
        {
        }
    }
}
