using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umamusume.Model
{
public class BestRankInfo 
{
	
	public int? race_instance_id; 
	public int? best_rank; 

	

	

}


public class CharaProfileData 
{
	
	public int? chara_id; 
	public int? data_id; 
	public int? new_flag; 

	

	

}


public class CharaRaceReward 
{
	
	public int? result_rank; 
	public int? result_time; 
	public RaceRewardData[] race_reward; 
	public RaceRewardData[] race_reward_bonus; 
	public int? gained_fans; 
	public int[] campaign_id_array; 

	

	

}


public class CharacterStoryData 
{
	
	public int? episode_id; 
	public int? state; 

	

	

}


public class ChoiceArray 
{
	
	public int? select_index; 
	public int? receive_item_id; 
	public int? target_race_id; 

	

	

}


public class CircleAtLoad 
{
	
	public CircleInfoAtFriend circle_info; 
	public CircleUser circle_user; 

	

	

}


public class CircleChatMessage 
{
	
	public int? post_id; 
	public int? viewer_id; 
	public int? message_type; 
	public int? message_id; 
	public string message_data; 
	public string create_time; 

	

	

}


public class CircleChatUser 
{
	
	public int? viewer_id; 
	public string name; 
	public int? leader_chara_id; 
	public int? leader_chara_dress_id; 

	

	

}


public class CircleInfo 
{
	
	public int? circle_id; 
	public int? leader_viewer_id; 
	public string name; 
	public string comment; 
	public int? member_num; 
	public int? join_style; 
	public int? policy; 
	public string make_time; 

	

	

}


public class CircleInfoAtFriend 
{
	
	public int? circle_id; 
	public string name; 
	public int? monthly_rank; 

	

	

}


public class CircleItemDonate 
{
	
	public int? donate_id; 
	public int? request_id; 
	public int? viewer_id; 
	public int? item_num; 
	public int? state; 
	public string create_time; 

	

	

}


public class CircleRanking 
{
	
	public int? circle_id; 
	public ulong point; 
	public int? monthly; 
	public int? rank; 

	

	

}


public class CircleScout 
{
	
	public int? circle_id; 
	public int? viewer_id; 

	

	

}


public class CircleUser 
{
	
	public int? viewer_id; 
	public int? circle_id; 
	public int? membership; 
	public string join_time; 
	public string penalty_end_time; 
	public string item_request_end_time; 

	

	

}


public class CoinInfo 
{
	
	public int coin; 
	public int fcoin; 

	

	

}


public class CommonDefine 
{
	
	public int? change_date_hour; 
	public int? trained_chara_default_save_num; 
	public int? max_circle_member_num; 
	public int? max_circle_scout_num; 
	public int? item_request_expire; 
	public int? max_donate_num_total; 
	public int? max_donate_num_for_request; 
	public int? max_donate_count_day; 
	public int? max_trainer_point; 
	public int? trainer_point_recovery_time; 
	public int? trainer_point_recovery_unit_value; 
	public int? trainer_point_recovery_calc_base; 
	public int? max_race_point; 
	public int? race_point_recovery_time; 
	public int? race_point_recovery_unit_value; 
	public int? race_point_recovery_calc_base; 
	public int? single_mode_trainer_point_use_value; 
	public int? coefficient_money_required_strength; 
	public int? max_follow_num; 
	public int? max_follower_num; 
	public int? present_history_limit; 
	public int? team_stadium_reload_interval_ms; 
	public int? team_stadium_support_card_bonus_max; 
	public int? need_team_rank_play_daily_race; 
	public int? need_team_rank_play_circle; 

	

	

}


public class DailyRaceData 
{
	
	public int? daily_race_id; 
	public int? is_cleared; 
	public int? is_played; 

	

	

}


public class DailyRacePlayingInfo 
{
	
	public int? state; 
	public int? trained_chara_id; 
	public DailyRaceData[] daily_race_record_array; 

	

	

}


public class DataHeader 
{
	
	public int viewer_id; 
	public string sid; 
	public long servertime; 
	public GallopResultCode result_code; 
	public string error_message; 
	public NotificationInfo notifications; 
	public ServerList server_list; 
	public string store_url; 
	public string service_preparation_message; 
	public string resource_version; 
	public string nonce; 

	

	

}


public class DirectoryCard 
{
	
	public int? card_id; 
	public int? directory_ranking; 
	public TrainedChara trained_chara; 

	

	

}


public class DirectoryCategoryScoreSummary 
{
	
	public int? score; 
	public int? number; 

	

	

}


public class DirectoryScoreSummary 
{
	
	public int? directory_card; 
	public DirectoryCategoryScoreSummary album; 
	public DirectoryCategoryScoreSummary story; 
	public DirectoryCategoryScoreSummary act; 
	public DirectoryCategoryScoreSummary voice; 
	public DirectoryCategoryScoreSummary nickname; 

	

	

}


public class DisplayRewardInfo 
{
	
	public int? item_type; 
	public int? item_id; 
	public int? item_num; 

	

	

}


public class EvaluationInfo 
{
	
	public int? target_id; 
	public int? evaluation; 
	public int? is_outing; 
	public int? story_step; 
	public int? is_appear; 

	

	

}


public class EventContentsInfo 
{
	
	public int? support_card_id; 
	public int? show_clear; 
	public int? show_clear_sort_id; 
	public ChoiceArray[] choice_array; 

	

	

}


public class EventSkill 
{
	
	public int? story_id; 
	public int[] skill_id_array; 

	

	

}


public class GachaBannerInfo 
{
	
	public int? id; 

	

	

}


public class GachaCampaignInfo 
{
	
	public int? id; 
	public int? is_campaign_draw_enable_single; 
	public int? is_campaign_draw_enable_multi; 

	

	

}


public class GachaInfoList 
{
	
	public int? id; 
	public int? is_daily_draw_end; 
	public int? prize_selected_card_type; 
	public int? prize_selected_card_id; 
	public int? is_campaign_draw_enable_single; 
	public int? is_campaign_draw_enable_multi; 

	

	

}


public class GachaLimitInfo 
{
	
	public GachaLimitItemInfo[] limit_item_list; 
	public GachaLimitItemInfo[] expired_limit_item_list; 
	public RewardSummaryInfo reward_summary_info; 

	

	

}


public class GachaLimitItemInfo 
{
	
	public int? gacha_id; 
	public int? num; 
	public int? converted_item_num; 

	

	

}


public class GachaPrizeHistory 
{
	
	public GachaPrizeResultInfo[] result_info_array; 
	public string exec_time; 

	

	

}


public class GachaPrizeResultInfo 
{
	
	public int? place; 
	public int? num; 

	

	

}


public class GachaResultData 
{
	
	public int? card_type; 
	public int? card_id; 
	public int? piece_id; 
	public int? common_item_category; 
	public int? common_item_id; 
	public int? convert_piece_num; 
	public int? convert_common_item_num; 
	public int? additional_piece_num; 
	public int? new_flag; 
	public int? win_prize; 

	

	

}


public class GainSkillInfo 
{
	
	public int? skill_id; 
	public int? level; 

	

	

}


public class HomeCharacterDressInfo 
{
	
	public int? position1_chara_id; 
	public int? position2_chara_id; 
	public int? position3_chara_id; 
	public int? position4_chara_id; 
	public int? position1_cloth_id; 
	public int? position2_cloth_id; 
	public int? position3_cloth_id; 
	public int? position4_cloth_id; 

	

	

}


public class HomePosterDataForDisplay 
{
	
	public int? id; 

	

	

}


public class HomePosterDataForRegist 
{
	
	public int? id; 

	

	

}


public class HomeStoryDataForDisplay 
{
	
	public int? id; 

	

	

}


public class HomeStoryDataForRegist 
{
	
	public int? id; 

	

	

}


public class HonorData 
{
	
	public int? honor_id; 
	public string create_time; 

	

	

}


public class HonorInfo 
{
	
	public HonorData[] honor_list; 
	public long last_checked_time; 

	

	

}


public class InviteHistory 
{
	
	public int? circle_id; 
	public int? room_id; 
	public int? viewer_id; 
	public int? race_type; 
	public string create_time; 

	

	

}


public class ItemExchangeLimit 
{
	
	public int? item_exchange_id; 
	public int? exchange_count; 

	

	

}


public class LastCheckedTime 
{
	
	public int? type; 
	public long last_checked_time; 

	

	

}


public class LegendRaceData 
{
	
	public int? legend_race_id; 
	public int? is_cleared; 
	public int? is_played; 
	public RaceHorseData boss_data; 

	

	

}


public class LegendRacePlayingInfo 
{
	
	public int? state; 
	public int? group_id; 
	public int? next_group_id; 
	public int? trained_chara_id; 
	public LegendRaceData[] legend_race_record_array; 

	

	

}


public class LimitedGoodsInfo 
{
	
	public int? disp_order; 
	public int? reward_id; 

	

	

}


public class LimitedShopInfo 
{
	
	public int? limited_exchange_id; 
	public int? open_flag; 
	public int? appear_flag; 
	public int? close_time; 
	public int? open_count; 

	

	

}


public class LiveTheaterMemberInfo 
{
	
	public int? chara_id; 
	public int? mob_id; 
	public int? dress_id; 
	public int? color_id; 

	

	

}


public class LiveTheaterSaveInfo 
{
	
	public int? music_id; 
	public LiveTheaterMemberInfo[] member_info_array; 
	public int? is_skip_story; 

	

	

}


public class LiveTheaterSettingInfo 
{
	
	public int? sound_live_music; 
	public int? display_lyrics; 
	public int? play_se; 
	public int? portrait_mode; 

	

	

}


public class LoginBonusData 
{
	
	public int? login_bonus_id; 
	public int? total_count; 

	

	

}


public class LoginUserTrophyInfo 
{
	
	public int? trophy_id; 
	public int[] chara_id_array; 

	

	

}


public class LovePointChangeData 
{
	
	public int? chara_id; 
	public int[] love_point; 

	

	

}


public class LovePointInfo 
{
	
	public int? chara_id; 
	public int? love_point_before; 
	public int? love_point_after; 

	

	

}


public class LoveStoryData 
{
	
	public int? episode_id; 
	public int? state; 

	

	

}


public class MainStoryData 
{
	
	public int? episode_id; 
	public int? state; 

	

	

}


public class MainStoryRaceEntryChara 
{
	
	public int? frame_order; 
	public int? chara_id; 
	public int? mob_id; 
	public int? dress_id; 
	public int? rank; 

	

	

}


public class MenuBadgeInfo 
{
	
	public int? present_num; 
	public int? mission_num; 
	public int? new_gacha_flag; 

	

	

}


public class MinigameResult 
{
	
	public int? result_state; 
	public int? result_value; 
	public MinigameResultDetail[] result_detail_array; 

	

	

}


public class MinigameResultDetail 
{
	
	public int? get_id; 
	public int? chara_id; 
	public int? dress_id; 
	public string motion; 
	public string face; 

	

	

}


public class MonthlyFanInfo 
{
	
	public int? ranking_year_month; 
	public int? num; 

	

	

}


public class NoReceivePresentNum 
{
	
	public int? no_time_limit_present_num; 
	public int? time_limit_present_num; 

	

	

}


public class NotUpParameterInfo 
{
	
	public int[] status_type_array; 
	public int[] chara_effect_id_array; 
	public int[] skill_id_array; 
	public SkillTips[] skill_tips_array; 
	public int[] skill_lv_id_array; 
	public int[] evaluation_chara_id_array; 
	public int[] command_lv_array; 

	

	

}


public class NoteDataForDisplay 
{
	
	public int? chara_id; 
	public int? data_id; 
	public string create_time; 
	public int? new_flag; 

	

	

}


public class NoteDataForRegist 
{
	
	public int? chara_id; 
	public int? data_id; 

	

	

}


public class NotificationInfo 
{
	
	public UserMission[] mission; 
	public int? add_present_num; 
	public int? unread_information_exists; 
	public int? unchecked_new_follower_count; 
	public int? trophy_badge_flag; 
	public int? circle_action_flag; 
	public int? team_stadium_reward_flag; 
	public int? directory_guide_flag; 
	public HonorData[] new_honor_data_array; 

	

	

}


public class OptionSupportCardFavoriteFlag 
{
	
	public int? rarity; 
	public int? status; 

	

	

}


public class PartnerCharacterLoginParam 
{
	
	public int? card_id; 
	public int? level; 

	

	

}


public class PaymentCoinBreakDownInfo 
{
	
	public int? user_coin_id; 
	public int? product_master_id; 
	public int? coin; 
	public string payment_money; 
	public string currency_code; 

	

	

}


public class PaymentDummyFinishParam 
{
	
	public int? agegroup; 
	public string signature; 
	public string original_receipt; 
	public string currency_code; 
	public string price; 
	public string purchase_id; 

	

	

}


public class PaymentFinishParam 
{
	
	public int? agegroup; 
	public string signature; 
	public string original_receipt; 
	public string currency_code; 
	public string price; 
	public string purchase_id; 

	

	

}


public class PaymentPurchaseItemParam 
{
	
	public int? id; 
	public string store_product_id; 
	public string name; 
	public int? disp_order; 
	public double price; 
	public string formatted_price; 
	public int? charge_num; 
	public int? free_num; 
	public int? limit_num; 
	public int? limit_type; 
	public int? item_pack_id; 
	public int? recommended_flag; 
	public long start_time; 
	public long end_time; 
	public int? number_of_product_purchased; 

	

	

}


public class PaymentPurchaseTimesData 
{
	
	public string product_id; 
	public int? number_of_product_purchased; 
	public int? limit_of_product_purchased; 

	

	

}


public class PaymentPurchasedTimes 
{
	
	public string product_id; 
	public int? num_of_purchases; 
	public int? limit_type; 
	public int? item_pack_id; 
	public int? limit; 

	

	

}


public class PaymentSeasonPackInfo 
{
	
	public int? product_master_id; 
	public int? season_end_time; 
	public int? repurchase_time; 
	public int? notice_status; 

	

	

}


public class PaymentStartParam 
{
	
	public string product_id; 
	public string price; 
	public string currency_code; 
	public string error_message; 

	

	

}


public class PaymentTotalInfo 
{
	
	public long paymentTotal; 

	

	

}


public class PieceData 
{
	
	public int? piece_id; 
	public int? piece_num; 

	

	

}


public class PresentData 
{
	
	public int? present_id; 
	public int? state; 
	public int? reward_type; 
	public int? reward_id; 
	public int? reward_count; 
	public int? message_id; 
	public int? message_param_value_1; 
	public int? message_param_value_2; 
	public int? message_param_value_3; 
	public int? message_param_value_4; 
	public long reward_limit_time; 
	public string create_time; 
	public string receive_time; 

	

	

}


public class PresentReceiveOption 
{
	
	public OptionSupportCardFavoriteFlag[] support_card_favorite_flag; 

	

	

}


public class RaceHorseData 
{
	
	public int? viewer_id; 
	public int? owner_viewer_id; 
	public string trainer_name; 
	public string owner_trainer_name; 
	public int? single_mode_chara_id; 
	public int? trained_chara_id; 
	public int? nickname_id; 
	public int? card_id; 
	public int? chara_id; 
	public int? rarity; 
	public int? talent_level; 
	public int? frame_order; 
	public SkillData[] skill_array; 
	public int? stamina; 
	public int? speed; 
	public int? pow; 
	public int? guts; 
	public int? wiz; 
	public int? running_style; 
	public int? race_dress_id; 
	public int? npc_type; 
	public int? final_grade; 
	public int? popularity; 
	public int[] popularity_mark_rank_array; 
	public int? proper_distance_short; 
	public int? proper_distance_mile; 
	public int? proper_distance_middle; 
	public int? proper_distance_long; 
	public int? proper_running_style_nige; 
	public int? proper_running_style_senko; 
	public int? proper_running_style_sashi; 
	public int? proper_running_style_oikomi; 
	public int? proper_ground_turf; 
	public int? proper_ground_dirt; 
	public int? motivation; 
	public int? mob_id; 
	public int[] win_saddle_id_array; 
	public RaceHorseDataRaceResult[] race_result_array; 
	public int? team_id; 
	public int? team_member_id; 
	public int[] item_id_array; 
	public int? motivation_change_flag; 
	public int? frame_order_change_flag; 

	

	

}


public class RaceHorseDataRaceResult 
{
	
	public int? turn; 
	public int? program_id; 
	public int? result_rank; 

	

	

}


public class RaceInstanceInfo 
{
	
	public int? race_instance_id; 
	public TrophyCharaInfo[] trophy_chara_info_array; 

	

	

}


public class RaceResultData 
{
	
	public int? viewer_id; 
	public int? finish_order; 
	public int? finish_time; 
	public int? finish_time_raw; 
	public int? bashin_diff_from_behind; 

	

	

}


public class RaceRewardData 
{
	
	public int? item_type; 
	public int? item_id; 
	public int? item_num; 

	

	

}


public class RaceRewardSetData 
{
	
	public RaceRewardData[] reward_list; 
	public int? trainer_exp; 
	public int? love_point; 
	public TrainedCharaParam trained_chara_param; 

	

	

}


public class RaceSimulateResult 
{
	
	public int? viewer_id; 
	public int? single_mode_chara_id; 
	public int? finish_order; 
	public int? time; 
	public int? popularity; 
	public int[] popularity_mark_rank_array; 
	public TeamStadiumResultHorseScore score; 

	

	

}


public class ReleaseNumInfo 
{
	
	public int? voice_num; 
	public int? act_num; 
	public int? good_end_num; 
	public int? music_num; 
	public int? main_story_num; 
	public int? chara_story_num; 
	public int? card_num; 
	public int? support_card_num; 

	

	

}


public class ReleasedEpisodeDataForDisplay 
{
	
	public int? id; 

	

	

}


public class ReleasedEpisodeDataForRegist 
{
	
	public int? id; 

	

	

}



public class RewardAddSupportCardNum 
{
	
	public int support_card_id; 
	public int number; 

	

	

}


public class RewardSummaryInfo 
{
	
	public int? add_present_num; 
	public UserItem[] add_item_list; 
	public UserCard[] add_card_list; 
	public RewardSummaryInfo add_card_bonus_info; 
	public UserSupportCard[] add_support_card_list; 
	public RewardAddSupportCardNum[] add_support_card_num_array; 
	public UserChara[] add_chara_list; 
	public UserCloth[] add_cloth_list; 
	public UserMusic[] add_music_list; 
	public int add_fcoin; 
	public HonorData[] add_honor_list; 
	public PieceData[] add_piece_list; 
	public int add_total_fan; 
	public CharaProfileData[] new_chara_profile_array; 

	

	

}


public class RpInfo 
{
	
	public int? current_rp; 
	public int? max_rp; 
	public int? max_recovery_time; 

	

	

}


public class SelectSupportCardList 
{
	
	public int? partner_id; 
	public int? card_id; 
	public int? level; 
	public int? limit_break_count; 

	

	

}


public class SellSupportCardInfo 
{
	
	public int? support_card_id; 
	public int? stock; 
	public int? client_own_stock; 

	

	

}


public class ServerList 
{
	
	public string resource_server; 
	public string resource_server_cf; 

	

	

}


public class ShortEpisodeDataForDisplay 
{
	
	public int? id; 

	

	

}


public class ShortEpisodeDataForRegist 
{
	
	public int? id; 

	

	

}


public class SingleModeBonusEffect 
{
	
	public int? target_type; 
	public int? min; 
	public int? max; 

	

	

}


public class SingleModeChara 
{
	
	public int? single_mode_chara_id; 
	public int? card_id; 
	public int? chara_grade; 
	public int? speed; 
	public int? stamina; 
	public int? power; 
	public int? wiz; 
	public int? guts; 
	public int? vital; 
	public int? max_speed; 
	public int? max_stamina; 
	public int? max_power; 
	public int? max_wiz; 
	public int? max_guts; 
	public int? default_max_speed; 
	public int? default_max_stamina; 
	public int? default_max_power; 
	public int? default_max_wiz; 
	public int? default_max_guts; 
	public int? max_vital; 
	public int? motivation; 
	public int? fans; 
	public int? rarity; 
	public int? race_program_id; 
	public int? reserve_race_program_id; 
	public int? race_running_style; 
	public int? is_short_race; 
	public int? talent_level; 
	public SkillData[] skill_array; 
	public int[] disable_skill_id_array; 
	public SkillTips[] skill_tips_array; 
	public SingleModeSupportCard[] support_card_array; 
	public int? succession_trained_chara_id_1; 
	public int? succession_trained_chara_id_2; 
	public int? proper_distance_short; 
	public int? proper_distance_mile; 
	public int? proper_distance_middle; 
	public int? proper_distance_long; 
	public int? proper_running_style_nige; 
	public int? proper_running_style_senko; 
	public int? proper_running_style_sashi; 
	public int? proper_running_style_oikomi; 
	public int? proper_ground_turf; 
	public int? proper_ground_dirt; 
	public int? turn; 
	public int? skill_point; 
	public int? short_cut_state; 
	public int? state; 
	public int? playing_state; 
	public int? scenario_id; 
	public int? route_id; 
	public EvaluationInfo[] evaluation_info_array; 
	public TrainingLevelInfo[] training_level_info_array; 
	public int[] nickname_id_array; 
	public int[] chara_effect_id_array; 
	public int[] route_race_id_array; 

	

	

}


public class SingleModeCharaEdit 
{
	
	public int? trained_chara_id; 
	public int[] selected_skill_ids; 

	

	

}


public class SingleModeCharaInfo 
{
	
	public int? trained_chara_id; 
	public int? program_id; 
	public int[] sense_bonus_ids; 
	public SingleModeExecCommand[] exec_commands; 

	

	

}


public class SingleModeCharaLight 
{
	
	public int? single_mode_chara_id; 
	public int? card_id; 
	public int? chara_grade; 
	public int? speed; 
	public int? stamina; 
	public int? power; 
	public int? wiz; 
	public int? guts; 
	public int? vital; 
	public int? max_vital; 
	public int? motivation; 
	public int? fans; 
	public int? rarity; 
	public int? race_program_id; 
	public int? reserve_race_turn; 
	public int? reserve_race_program_id; 
	public int? race_running_style; 
	public int? talent_level; 
	public int? proper_distance_short; 
	public int? proper_distance_mile; 
	public int? proper_distance_middle; 
	public int? proper_distance_long; 
	public int? proper_running_style_nige; 
	public int? proper_running_style_senko; 
	public int? proper_running_style_sashi; 
	public int? proper_running_style_oikomi; 
	public int? proper_ground_turf; 
	public int? proper_ground_dirt; 
	public int? turn; 
	public int? skill_point; 
	public int? short_cut_state; 
	public int? state; 
	public int? playing_state; 
	public int? scenario_id; 
	public int? route_id; 
	public int? succession_trained_chara_id_1; 
	public int? succession_trained_chara_id_2; 
	public int[] route_race_id_array; 

	

	

}


public class SingleModeCommandInfo 
{
	
	public int? command_type; 
	public int? command_id; 
	public int? is_enable; 
	public int[] training_partner_array; 
	public int[] tips_event_partner_array; 
	public SingleModeParamsIncDecInfo[] params_inc_dec_info_array; 
	public int? failure_rate; 

	

	

}


public class SingleModeCommandResult 
{
	
	public int? command_id; 
	public int? sub_id; 
	public int? result_state; 

	

	

}


public class SingleModeEventInfo 
{
	
	public int? event_id; 
	public int? chara_id; 
	public int? story_id; 
	public int? play_timing; 
	public EventContentsInfo event_contents_info; 
	public SingleModeSuccessionEventInfo succession_event_info; 
	public MinigameResult minigame_result; 

	

	

}


public class SingleModeExecCommand 
{
	
	public int? command_type; 
	public int? command_id; 
	public int? sub_id; 
	public int? command_num; 

	

	

}


public class SingleModeFriendSupportCard 
{
	
	public UserInfoAtFriend[] summary_user_info_array; 
	public UserSupportCard[] support_card_data_array; 

	

	

}


public class SingleModeFriendSupportCardInfo 
{
	
	public int? viewer_id; 
	public int? support_card_id; 

	

	

}


public class SingleModeHomeInfo 
{
	
	public SingleModeCommandInfo[] command_info_array; 
	public int? race_entry_restriction; 
	public int[] disable_command_id_array; 
	public int? available_continue_num; 
	public long free_continue_time; 
	public int? shortened_race_state; 

	

	

}


public class SingleModeInfo 
{
	
	public int? month; 
	public int? total_turn; 
	public int? room_num; 

	

	

}


public class SingleModeParamsIncDecInfo 
{
	
	public int? target_type; 
	public int? value; 

	

	

}


public class SingleModeRaceCharaResult 
{
	
	public int? single_mode_chara_id; 
	public int? frame_order; 
	public int? running_style; 
	public int? result_rank; 
	public int? result_time; 
	public int? result_time_raw; 
	public int? bashin_diff; 
	public int? bashin_diff_from_top; 
	public int? skill_activate_count; 
	public int? is_excitement; 
	public int? is_running_alone; 
	public int? last_straight_line_rank; 

	

	

}


public class SingleModeRaceCondition 
{
	
	public int? program_id; 
	public int? weather; 
	public int? ground_condition; 

	

	

}


public class SingleModeRaceMobNpcResult 
{
	
	public int? mob_id; 
	public int? result_rank; 
	public int? result_time; 
	public int? result_time_raw; 
	public int? running_style; 
	public int? frame_order; 

	

	

}


public class SingleModeRaceResult 
{
	
	public int? program_id; 
	public int? race_instance_id; 
	public int? weather; 
	public int? ground_condition; 
	public SingleModeRaceCharaResult chara_result; 
	public SingleModeRaceUniqueNpcResult[] unique_npc_result; 
	public SingleModeRaceMobNpcResult[] mob_npc_result; 
	public int? start_dash_state; 

	

	

}


public class SingleModeRaceUniqueNpcResult 
{
	
	public int? chara_id; 
	public int? result_rank; 
	public int? result_time; 
	public int? result_time_raw; 
	public int? running_style; 
	public int? frame_order; 

	

	

}


public class SingleModeRentalSuccessionChara 
{
	
	public int? viewer_id; 
	public int? trained_chara_id; 
	public bool is_circle_member; 

	

	

}


public class SingleModeResultBonusEffect 
{
	
	public int? target_type; 
	public int? effect_value; 

	

	

}


public class SingleModeSpecialTrainingInfo 
{
	
	public int? command_type; 
	public int? command_id; 
	public int? support_card_position; 
	public SingleModeParamsIncDecInfo[] params_inc_dec_info_array; 

	

	

}


public class SingleModeStartChara 
{
	
	public int? card_id; 
	public int[] support_card_ids; 
	public SingleModeFriendSupportCardInfo friend_support_card_info; 
	public int? succession_trained_chara_id_1; 
	public int? succession_trained_chara_id_2; 
	public SingleModeRentalSuccessionChara rental_succession_trained_chara; 
	public int? scenario_id; 

	

	

}


public class SingleModeSuccessionEventInfo 
{
	
	public int? effect_type; 

	

	

}


public class SingleModeSuccessionTrainedChara 
{
	
	public UserInfoAtFriend[] summary_user_info_array; 
	public TrainedChara[] succession_trained_chara_array; 

	

	

}


public class SingleModeSupportCard 
{
	
	public int? position; 
	public int? support_card_id; 
	public int? limit_break_count; 
	public int? exp; 
	public int? training_partner_state; 
	public int? owner_viewer_id; 

	

	

}


public class SingleModeTargetRace 
{
	
	public int? target_turn; 
	public int? target_type; 
	public int? target_value; 

	

	

}


public class SingleRaceHistory 
{
	
	public int? turn; 
	public int? program_id; 
	public int? weather; 
	public int? ground_condition; 
	public int? running_style; 
	public int? result_rank; 

	

	

}


public class SingleRaceStartInfo 
{
	
	public int? program_id; 
	public int? random_seed; 
	public int? weather; 
	public int? ground_condition; 
	public RaceHorseData[] race_horse_data; 
	public int? continue_num; 

	

	

}


public class SkillData 
{
	
	public int? skill_id; 
	public int? level; 

	

	

}


public class SkillTips 
{
	
	public int? group_id; 
	public int? rarity; 
	public int? level; 

	

	

}


public class StoryDirectEventReward 
{
	
	public int? id; 
	public int? gain_id; 
	public int? gain_type; 
	public int? gain_value_1; 
	public int? gain_value_2; 
	public int? gain_value_3; 
	public int? gain_value_4; 

	

	

}


public class StoryDirectSkillSet 
{
	
	public int? id; 
	public int? skill_set; 
	public int? skill_id; 
	public int? add_skill_discount; 

	

	

}


public class SuccessionChara 
{
	
	public int? position_id; 
	public int? card_id; 
	public int? rank; 
	public int? rarity; 
	public int? talent_level; 
	public int[] factor_id_array; 
	public int[] win_saddle_id_array; 
	public int? owner_viewer_id; 
	public UserInfoAtFriend user_info_summary; 

	

	

}


public class SuccessionEffectedFactor 
{
	
	public int? position; 
	public int[] factor_id_array; 

	

	

}


public class SuccessionHistory 
{
	
	public int? id; 
	public int? viewer_id; 
	public int? trained_chara_id; 
	public int? hisotry_type; 
	public int? succession_card_id; 
	public int? date; 
	public string user_name; 
	public string circle_name; 

	

	

}


public class TalkData 
{
	
	public int? story_id; 
	public bool is_open; 

	

	

}


public class TeamStadiumAddFanInfo 
{
	
	public int? chara_id; 
	public int? add_fan; 

	

	

}


public class TeamStadiumBonusData 
{
	
	public int? score_bonus_id; 
	public int? bonus_score; 

	

	

}


public class TeamStadiumBorderLine 
{
	
	public int? promotion_rank; 
	public int? demotion_rank; 
	public int? keep_rank; 
	public int? promotion_point; 
	public int? demotion_point; 
	public int? keep_point; 

	

	

}


public class TeamStadiumFrameOrder 
{
	
	public int? distance_type; 
	public int? race_order; 
	public TeamStadiumRandomInfo[] random_info_array; 

	

	

}


public class TeamStadiumOpponent 
{
	
	public int? strength; 
	public int? opponent_viewer_id; 
	public int? evaluation_point; 
	public UserInfoAtFriend user_info; 
	public TeamStadiumTeamData[] team_data_array; 
	public TrainedChara[] trained_chara_array; 
	public int? winning_reward_guarantee_status; 

	

	

}


public class TeamStadiumRaceCharaResult 
{
	
	public int? viewer_id; 
	public int? frame_order; 
	public int? trained_chara_id; 
	public int? team_id; 
	public int? finish_order; 
	public int? finish_time; 
	public TeamStadiumResultScoreData[] score_array; 

	

	

}


public class TeamStadiumRaceResult 
{
	
	public int? distance_type; 
	public string race_scenario; 
	public int? round; 
	public TeamStadiumResultScoreData[] team_score_array; 
	public int? team_total_score; 
	public int? win_type; 
	public int? current_consecutive_win_count; 
	public int? bonus_rate_by_next_win; 
	public TeamStadiumRaceCharaResult[] chara_result_array; 

	

	

}


public class TeamStadiumRaceSimulateCharaResult 
{
	
	public int? viewer_id; 
	public int? single_mode_chara_id; 
	public int? finish_order; 
	public int? finish_time; 
	public int? finish_time_raw; 
	public TeamStadiumResultHorseScore score; 
	public int[] skill_activate_count_array; 

	

	

}


public class TeamStadiumRaceSimulateResult 
{
	
	public string race_scenario; 
	public TeamStadiumRaceSimulateCharaResult[] result_array; 
	public TeamStadiumResultTeam result_team; 

	

	

}


public class TeamStadiumRaceStartParams 
{
	
	public int? round; 
	public int? race_instance_id; 
	public int? season; 
	public int? weather; 
	public int? ground_condition; 
	public int? random_seed; 
	public RaceHorseData[] race_horse_data_array; 
	public int? self_evaluate; 
	public int? opponent_evaluate; 

	

	

}


public class TeamStadiumRandomInfo 
{
	
	public int? viewer_id; 
	public int? member_id; 
	public int? trained_chara_id; 
	public int? running_style; 
	public int? frame_order; 
	public int? motivation; 

	

	

}


public class TeamStadiumRanking 
{
	
	public int? term_id; 
	public int? viewer_id; 
	public int? team_class; 
	public int? best_point; 
	public int? rank; 

	

	

}


public class TeamStadiumResultBonusData 
{
	
	public int? score_bonus_id; 
	public int? bonus_score; 
	public int? condition_type; 
	public int? condition_value_1; 
	public int? condition_value_2; 
	public int? score_rate; 

	

	

}


public class TeamStadiumResultHorseScore 
{
	
	public TeamStadiumScoreData[] score_array; 

	

	

}


public class TeamStadiumResultScoreData 
{
	
	public int? raw_score_id; 
	public int? num; 
	public int? score; 
	public TeamStadiumResultBonusData[] bonus_array; 

	

	

}


public class TeamStadiumResultTeam 
{
	
	public int? team_id; 
	public TeamStadiumScoreData[] team_score_array; 
	public int? team_total_score; 

	

	

}


public class TeamStadiumScoreData 
{
	
	public int? raw_score_id; 
	public int? num; 
	public int? score; 
	public TeamStadiumBonusData[] bonus_array; 

	

	

}


public class TeamStadiumTeamData 
{
	
	public int? distance_type; 
	public int? member_id; 
	public int? trained_chara_id; 
	public int? running_style; 

	

	

}


public class TeamStadiumTotalScoreInfo 
{
	
	public int? final_total_score; 
	public int? all_race_result_score_bonus; 

	

	

}


public class TeamStadiumUser 
{
	
	public int? team_class; 
	public int? best_team_class; 
	public int? best_point; 

	

	

}


public class TeamStadiumWinningRewardContent 
{
	
	public int? round; 
	public int? item_category; 
	public int? item_id; 
	public int? item_num; 
	public int? box_color_type; 

	

	

}


public class TeamStadiumWinningRewardInfo 
{
	
	public int? round; 
	public int? box_color_type; 

	

	

}


public class TpInfo 
{
	
	public int? current_tp; 
	public int? max_tp; 
	public int? max_recovery_time; 

	

	

}


public class TrainedChara 
{
	
	public int? viewer_id; 
	public int? trained_chara_id; 
	public int? owner_viewer_id; 
	public int? card_id; 
	public string name; 
	public int? stamina; 
	public int? speed; 
	public int? power; 
	public int? guts; 
	public int? wiz; 
	public int? fans; 
	public int? rank_score; 
	public int? rank; 
	public int? proper_distance_short; 
	public int? proper_distance_mile; 
	public int? proper_distance_middle; 
	public int? proper_distance_long; 
	public int? proper_running_style_nige; 
	public int? proper_running_style_senko; 
	public int? proper_running_style_sashi; 
	public int? proper_running_style_oikomi; 
	public int? proper_ground_turf; 
	public int? proper_ground_dirt; 
	public int? succession_num; 
	public int? is_locked; 
	public int? rarity; 
	public int? talent_level; 
	public int? chara_grade; 
	public int? running_style; 
	public int? nickname_id; 
	public int? wins; 
	public SkillData[] skill_array; 
	public TrainedCharaSupportCardList[] support_card_list; 
	public int? is_saved; 
	public TrainedCharaRaceResult[] race_result_list; 
	public int[] win_saddle_id_array; 
	public int[] nickname_id_array; 
	public int[] factor_id_array; 
	public SuccessionChara[] succession_chara_array; 
	public SuccessionHistory[] succession_history_array; 
	public int? scenario_id; 
	public string create_time; 

	

	

}


public class TrainedCharaParam 
{
	
	public int[] skill; 
	public int? stamina; 
	public int? speed; 
	public int? power; 
	public int? guts; 
	public int? wiz; 

	

	

}


public class TrainedCharaRaceResult 
{
	
	public int? turn; 
	public int? program_id; 
	public int? weather; 
	public int? ground_condition; 
	public int? running_style; 
	public int? result_rank; 

	

	

}


public class TrainedCharaSupportCardList 
{
	
	public int? position; 
	public int? support_card_id; 
	public int? exp; 
	public int? limit_break_count; 

	

	

}


public class TrainingLevelInfo 
{
	
	public int? command_id; 
	public int? level; 

	

	

}


public class TrophyCharaInfo 
{
	
	public int? chara_id; 
	public int? win_count; 

	

	

}


public class TrophyNumInfo 
{
	
	public int? grade_1; 
	public int? grade_2; 
	public int? grade_3; 
	public int? grade_ex; 

	

	

}


public class TutorialGuideDataForDisplay 
{
	
	public int? id; 

	

	

}


public class TutorialGuideDataForRegist 
{
	
	public int? id; 

	

	

}


public class UseItemData 
{
	
	public int? item_id; 
	public int? item_num; 

	

	

}


public class UserCard 
{
	
	public int? card_id; 
	public int? rarity; 
	public int? talent_level; 
	public string create_time; 

	

	

}


public class UserChara 
{
	
	public int? chara_id; 
	public int? training_num; 
	public int? love_point; 
	public ulong fan; 

	

	

}


public class UserCloth 
{
	
	public int? cloth_id; 

	

	

}


public class UserFriend 
{
	
	public int? friend_viewer_id; 
	public int? state; 
	public string follow_time; 
	public string follower_time; 

	

	

}


public class UserInfo 
{
	
	public int viewer_id; 
	public string name; 
	public int? honor_id; 
	public int? sex; 
	public int tutorial_step; 
	public int? leader_chara_id; 
	public int? support_card_id; 
	public int? partner_chara_id; 
	public int? bonus_follow_num; 
	public string comment; 
	public string birth_day; 
	public ulong fan; 
	public int? directory_level; 
	public int? rank_score; 
	public int? best_team_evaluation_point; 
	public string create_time; 
	public string update_time; 
	public int? leader_chara_dress_id; 

	

	

}


public class UserInfoAtFollower 
{
	
	public int? viewer_id; 
	public string name; 
	public int? honor_id; 
	public string last_login_time; 
	public int? support_card_id; 
	public UserSupportCardAtFriend user_support_card; 

	

	

}


public class UserInfoAtFriend 
{
	
	public int? viewer_id; 
	public string name; 
	public int? honor_id; 
	public string last_login_time; 
	public int? leader_chara_id; 
	public int? support_card_id; 
	public string comment; 
	public ulong fan; 
	public int? directory_level; 
	public int? rank_score; 
	public int? team_stadium_win_count; 
	public int? single_mode_play_count; 
	public int? team_evaluation_point; 
	public int? best_team_evaluation_point; 
	public int? friend_state; 
	public CircleInfoAtFriend circle_info; 
	public CircleUser circle_user; 
	public UserSupportCardAtFriend user_support_card; 
	public int? leader_chara_dress_id; 
	public UserTrainedCharaAtFriend user_trained_chara; 

	

	

}


public class UserItem 
{
	
	public int? item_id; 
	public int? number; 

	

	

}


public class UserMission 
{
	
	public int? mission_id; 
	public int? mission_status; 
	public int? exec_count; 

	

	

}


public class UserMusic 
{
	
	public int? music_id; 
	public string acquisition_time; 

	

	

}


public class UserSupportCard 
{
	
	public int? viewer_id; 
	public int? support_card_id; 
	public int? exp; 
	public int? limit_break_count; 
	public int? favorite_flag; 
	public int? stock; 
	public string possess_time; 

	

	

}


public class UserSupportCardAtFriend 
{
	
	public int? support_card_id; 
	public int? exp; 
	public int? limit_break_count; 

	

	

}


public class UserSupportCardDeck 
{
	
	public int? deck_id; 
	public string name; 
	public int[] support_card_id_array; 

	

	

}


public class UserSupportCardDeckForUpdateParty 
{
	
	public int? deck_id; 
	public int[] support_card_id_array; 

	

	

}


public class UserTrainedCharaAtFriend 
{
	
	public int? viewer_id; 
	public int? trained_chara_id; 
	public int? card_id; 
	public int? rank_score; 
	public int? rank; 
	public int? proper_distance_short; 
	public int? proper_distance_mile; 
	public int? proper_distance_middle; 
	public int? proper_distance_long; 
	public int? proper_running_style_nige; 
	public int? proper_running_style_senko; 
	public int? proper_running_style_sashi; 
	public int? proper_running_style_oikomi; 
	public int? proper_ground_turf; 
	public int? proper_ground_dirt; 
	public int? rarity; 
	public int? talent_level; 
	public string register_time; 
	public int[] factor_id_array; 
	public int? skill_count; 

	

	

}


public class UserTrophyInfo 
{
	
	public int? trophy_id; 
	public string create_time; 
	public RaceInstanceInfo[] race_instance_info_array; 

	

	

}
	public class ResponseItem
	{
		public int? item_type;

		public int? item_id;

		public int? item_num;

		public ResponseItem()
		{
		}
	}


}
