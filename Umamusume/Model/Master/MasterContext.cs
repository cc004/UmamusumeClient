using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class MasterContext : DbContext
    {
        public MasterContext()
        {
        }

        public MasterContext(DbContextOptions<MasterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AnnounceCharacter> AnnounceCharacters { get; set; }
        public virtual DbSet<AnnounceDatum> AnnounceData { get; set; }
        public virtual DbSet<AnnounceSupportCard> AnnounceSupportCards { get; set; }
        public virtual DbSet<AudioCuesheet> AudioCuesheets { get; set; }
        public virtual DbSet<AudioIgnoredCueOnHighspeed> AudioIgnoredCueOnHighspeeds { get; set; }
        public virtual DbSet<AvailableSkillSet> AvailableSkillSets { get; set; }
        public virtual DbSet<BackgroundDatum> BackgroundData { get; set; }
        public virtual DbSet<BannerDatum> BannerData { get; set; }
        public virtual DbSet<CampaignCharaStorySchedule> CampaignCharaStorySchedules { get; set; }
        public virtual DbSet<CampaignDatum> CampaignData { get; set; }
        public virtual DbSet<CardDatum> CardData { get; set; }
        public virtual DbSet<CardRarityDatum> CardRarityData { get; set; }
        public virtual DbSet<CardTalentUpgrade> CardTalentUpgrades { get; set; }
        public virtual DbSet<CharaCategoryMotion> CharaCategoryMotions { get; set; }
        public virtual DbSet<CharaDatum> CharaData { get; set; }
        public virtual DbSet<CharaMotionAct> CharaMotionActs { get; set; }
        public virtual DbSet<CharaMotionSet> CharaMotionSets { get; set; }
        public virtual DbSet<CharaStoryDatum> CharaStoryData { get; set; }
        public virtual DbSet<CharaType> CharaTypes { get; set; }
        public virtual DbSet<CharacterPropAnimation> CharacterPropAnimations { get; set; }
        public virtual DbSet<CharacterSystemLottery> CharacterSystemLotteries { get; set; }
        public virtual DbSet<CharacterSystemText> CharacterSystemTexts { get; set; }
        public virtual DbSet<CircleRankDatum> CircleRankData { get; set; }
        public virtual DbSet<CircleStampDatum> CircleStampData { get; set; }
        public virtual DbSet<CraneGameArmSwing> CraneGameArmSwings { get; set; }
        public virtual DbSet<CraneGameCatchResult> CraneGameCatchResults { get; set; }
        public virtual DbSet<CraneGameDefineParam> CraneGameDefineParams { get; set; }
        public virtual DbSet<CraneGameExtraOddsCondition> CraneGameExtraOddsConditions { get; set; }
        public virtual DbSet<CraneGameHiddenOdd> CraneGameHiddenOdds { get; set; }
        public virtual DbSet<CraneGamePrizeFace> CraneGamePrizeFaces { get; set; }
        public virtual DbSet<CraneGamePrizePattern> CraneGamePrizePatterns { get; set; }
        public virtual DbSet<CraneGameProp> CraneGameProps { get; set; }
        public virtual DbSet<DailyPack> DailyPacks { get; set; }
        public virtual DbSet<DailyRace> DailyRaces { get; set; }
        public virtual DbSet<DailyRaceBilling> DailyRaceBillings { get; set; }
        public virtual DbSet<DailyRaceNpc> DailyRaceNpcs { get; set; }
        public virtual DbSet<Directory> Directories { get; set; }
        public virtual DbSet<DressDatum> DressData { get; set; }
        public virtual DbSet<EventMotionDatum> EventMotionData { get; set; }
        public virtual DbSet<EventMotionPlusDatum> EventMotionPlusData { get; set; }
        public virtual DbSet<FaceTypeDatum> FaceTypeData { get; set; }
        public virtual DbSet<FacialMouthChange> FacialMouthChanges { get; set; }
        public virtual DbSet<GachaAvailable> GachaAvailables { get; set; }
        public virtual DbSet<GachaDatum> GachaData { get; set; }
        public virtual DbSet<GachaExchange> GachaExchanges { get; set; }
        public virtual DbSet<GachaFreeCampaign> GachaFreeCampaigns { get; set; }
        public virtual DbSet<GachaPiece> GachaPieces { get; set; }
        public virtual DbSet<GachaPrizeOdd> GachaPrizeOdds { get; set; }
        public virtual DbSet<GachaTopBg> GachaTopBgs { get; set; }
        public virtual DbSet<GiftMessage> GiftMessages { get; set; }
        public virtual DbSet<HighlightInterpolate> HighlightInterpolates { get; set; }
        public virtual DbSet<HomeCharacterType> HomeCharacterTypes { get; set; }
        public virtual DbSet<HomeEnvSetting> HomeEnvSettings { get; set; }
        public virtual DbSet<HomePosterDatum> HomePosterData { get; set; }
        public virtual DbSet<HomePropSetting> HomePropSettings { get; set; }
        public virtual DbSet<HomeStoryTrigger> HomeStoryTriggers { get; set; }
        public virtual DbSet<HomeWalkGroup> HomeWalkGroups { get; set; }
        public virtual DbSet<HonorDatum> HonorData { get; set; }
        public virtual DbSet<ItemDatum> ItemData { get; set; }
        public virtual DbSet<ItemExchange> ItemExchanges { get; set; }
        public virtual DbSet<ItemExchangeTop> ItemExchangeTops { get; set; }
        public virtual DbSet<ItemGroup> ItemGroups { get; set; }
        public virtual DbSet<ItemPack> ItemPacks { get; set; }
        public virtual DbSet<ItemPlace> ItemPlaces { get; set; }
        public virtual DbSet<LegendRace> LegendRaces { get; set; }
        public virtual DbSet<LegendRaceBilling> LegendRaceBillings { get; set; }
        public virtual DbSet<LegendRaceBossNpc> LegendRaceBossNpcs { get; set; }
        public virtual DbSet<LegendRaceNpc> LegendRaceNpcs { get; set; }
        public virtual DbSet<LimitedExchange> LimitedExchanges { get; set; }
        public virtual DbSet<LimitedExchangeReward> LimitedExchangeRewards { get; set; }
        public virtual DbSet<LimitedExchangeRewardOdd> LimitedExchangeRewardOdds { get; set; }
        public virtual DbSet<LiveDatum> LiveData { get; set; }
        public virtual DbSet<LivePermissionDatum> LivePermissionData { get; set; }
        public virtual DbSet<LoginBonusDatum> LoginBonusData { get; set; }
        public virtual DbSet<LoginBonusDetail> LoginBonusDetails { get; set; }
        public virtual DbSet<LoveRank> LoveRanks { get; set; }
        public virtual DbSet<MainStoryDatum> MainStoryData { get; set; }
        public virtual DbSet<MainStoryPart> MainStoryParts { get; set; }
        public virtual DbSet<MainStoryRaceCharaDatum> MainStoryRaceCharaData { get; set; }
        public virtual DbSet<MainStoryRaceDatum> MainStoryRaceData { get; set; }
        public virtual DbSet<MiniBg> MiniBgs { get; set; }
        public virtual DbSet<MiniBgCharaMotion> MiniBgCharaMotions { get; set; }
        public virtual DbSet<MiniFaceTypeDatum> MiniFaceTypeData { get; set; }
        public virtual DbSet<MiniMotionSet> MiniMotionSets { get; set; }
        public virtual DbSet<MiniMouthType> MiniMouthTypes { get; set; }
        public virtual DbSet<MissionDatum> MissionData { get; set; }
        public virtual DbSet<MobDatum> MobData { get; set; }
        public virtual DbSet<MobDressColorSet> MobDressColorSets { get; set; }
        public virtual DbSet<MobHairColorSet> MobHairColorSets { get; set; }
        public virtual DbSet<NeedPieceNumDatum> NeedPieceNumData { get; set; }
        public virtual DbSet<Nickname> Nicknames { get; set; }
        public virtual DbSet<NoteProfile> NoteProfiles { get; set; }
        public virtual DbSet<NoteProfileTextType> NoteProfileTextTypes { get; set; }
        public virtual DbSet<PieceDatum> PieceData { get; set; }
        public virtual DbSet<PriceChange> PriceChanges { get; set; }
        public virtual DbSet<Race> Races { get; set; }
        public virtual DbSet<RaceBgm> RaceBgms { get; set; }
        public virtual DbSet<RaceBgmCutinExtensionTime> RaceBgmCutinExtensionTimes { get; set; }
        public virtual DbSet<RaceBgmPattern> RaceBgmPatterns { get; set; }
        public virtual DbSet<RaceBibColor> RaceBibColors { get; set; }
        public virtual DbSet<RaceCondition> RaceConditions { get; set; }
        public virtual DbSet<RaceCourseSet> RaceCourseSets { get; set; }
        public virtual DbSet<RaceCourseSetStatus> RaceCourseSetStatuses { get; set; }
        public virtual DbSet<RaceEnvDefine> RaceEnvDefines { get; set; }
        public virtual DbSet<RaceFenceSet> RaceFenceSets { get; set; }
        public virtual DbSet<RaceInstance> RaceInstances { get; set; }
        public virtual DbSet<RaceJikkyoBase> RaceJikkyoBases { get; set; }
        public virtual DbSet<RaceJikkyoComment> RaceJikkyoComments { get; set; }
        public virtual DbSet<RaceJikkyoCue> RaceJikkyoCues { get; set; }
        public virtual DbSet<RaceJikkyoMessage> RaceJikkyoMessages { get; set; }
        public virtual DbSet<RaceJikkyoRace> RaceJikkyoRaces { get; set; }
        public virtual DbSet<RaceJikkyoTrigger> RaceJikkyoTriggers { get; set; }
        public virtual DbSet<RaceMotivationRate> RaceMotivationRates { get; set; }
        public virtual DbSet<RaceOverrunPattern> RaceOverrunPatterns { get; set; }
        public virtual DbSet<RacePlayerCamera> RacePlayerCameras { get; set; }
        public virtual DbSet<RacePopularityProperValue> RacePopularityProperValues { get; set; }
        public virtual DbSet<RaceProperDistanceRate> RaceProperDistanceRates { get; set; }
        public virtual DbSet<RaceProperGroundRate> RaceProperGroundRates { get; set; }
        public virtual DbSet<RaceProperRunningstyleRate> RaceProperRunningstyleRates { get; set; }
        public virtual DbSet<RaceTrack> RaceTracks { get; set; }
        public virtual DbSet<RaceTrophy> RaceTrophies { get; set; }
        public virtual DbSet<RaceTrophyReward> RaceTrophyRewards { get; set; }
        public virtual DbSet<RandomEarTailMotion> RandomEarTailMotions { get; set; }
        public virtual DbSet<SeasonDatum> SeasonData { get; set; }
        public virtual DbSet<ShortEpisode> ShortEpisodes { get; set; }
        public virtual DbSet<SingleModeAnalyzeMessage> SingleModeAnalyzeMessages { get; set; }
        public virtual DbSet<SingleModeAnalyzeTicket> SingleModeAnalyzeTickets { get; set; }
        public virtual DbSet<SingleModeCharaEffect> SingleModeCharaEffects { get; set; }
        public virtual DbSet<SingleModeCharaGrade> SingleModeCharaGrades { get; set; }
        public virtual DbSet<SingleModeCharaProgram> SingleModeCharaPrograms { get; set; }
        public virtual DbSet<SingleModeConclusionSet> SingleModeConclusionSets { get; set; }
        public virtual DbSet<SingleModeEvaluation> SingleModeEvaluations { get; set; }
        public virtual DbSet<SingleModeEventConclusion> SingleModeEventConclusions { get; set; }
        public virtual DbSet<SingleModeEventProduction> SingleModeEventProductions { get; set; }
        public virtual DbSet<SingleModeFanCount> SingleModeFanCounts { get; set; }
        public virtual DbSet<SingleModeHintGain> SingleModeHintGains { get; set; }
        public virtual DbSet<SingleModeMessage> SingleModeMessages { get; set; }
        public virtual DbSet<SingleModeNpc> SingleModeNpcs { get; set; }
        public virtual DbSet<SingleModeOuting> SingleModeOutings { get; set; }
        public virtual DbSet<SingleModeOutingSet> SingleModeOutingSets { get; set; }
        public virtual DbSet<SingleModeProgram> SingleModePrograms { get; set; }
        public virtual DbSet<SingleModeRaceGroup> SingleModeRaceGroups { get; set; }
        public virtual DbSet<SingleModeRaceLive> SingleModeRaceLives { get; set; }
        public virtual DbSet<SingleModeRank> SingleModeRanks { get; set; }
        public virtual DbSet<SingleModeRecommend> SingleModeRecommends { get; set; }
        public virtual DbSet<SingleModeRecommendSetting> SingleModeRecommendSettings { get; set; }
        public virtual DbSet<SingleModeRewardSet> SingleModeRewardSets { get; set; }
        public virtual DbSet<SingleModeRival> SingleModeRivals { get; set; }
        public virtual DbSet<SingleModeRoute> SingleModeRoutes { get; set; }
        public virtual DbSet<SingleModeRouteRace> SingleModeRouteRaces { get; set; }
        public virtual DbSet<SingleModeScenario> SingleModeScenarios { get; set; }
        public virtual DbSet<SingleModeSkillNeedPoint> SingleModeSkillNeedPoints { get; set; }
        public virtual DbSet<SingleModeStoryDatum> SingleModeStoryData { get; set; }
        public virtual DbSet<SingleModeTagCardPo> SingleModeTagCardPos { get; set; }
        public virtual DbSet<SingleModeTopBg> SingleModeTopBgs { get; set; }
        public virtual DbSet<SingleModeTraining> SingleModeTrainings { get; set; }
        public virtual DbSet<SingleModeTrainingEffect> SingleModeTrainingEffects { get; set; }
        public virtual DbSet<SingleModeTrainingSe> SingleModeTrainingSes { get; set; }
        public virtual DbSet<SingleModeTurn> SingleModeTurns { get; set; }
        public virtual DbSet<SingleModeUniqueChara> SingleModeUniqueCharas { get; set; }
        public virtual DbSet<SingleModeWinsSaddle> SingleModeWinsSaddles { get; set; }
        public virtual DbSet<SkillDatum> SkillData { get; set; }
        public virtual DbSet<SkillExp> SkillExps { get; set; }
        public virtual DbSet<SkillLevelValue> SkillLevelValues { get; set; }
        public virtual DbSet<SkillRarity> SkillRarities { get; set; }
        public virtual DbSet<SkillSet> SkillSets { get; set; }
        public virtual DbSet<StoryEventBingoReward> StoryEventBingoRewards { get; set; }
        public virtual DbSet<StoryEventBonusCard> StoryEventBonusCards { get; set; }
        public virtual DbSet<StoryEventBonusSupportCard> StoryEventBonusSupportCards { get; set; }
        public virtual DbSet<StoryEventDatum> StoryEventData { get; set; }
        public virtual DbSet<StoryEventMission> StoryEventMissions { get; set; }
        public virtual DbSet<StoryEventMissionTopChara> StoryEventMissionTopCharas { get; set; }
        public virtual DbSet<StoryEventNicknameBonu> StoryEventNicknameBonus { get; set; }
        public virtual DbSet<StoryEventPointReward> StoryEventPointRewards { get; set; }
        public virtual DbSet<StoryEventRouletteBingo> StoryEventRouletteBingos { get; set; }
        public virtual DbSet<StoryEventStoryDatum> StoryEventStoryData { get; set; }
        public virtual DbSet<StoryEventTopChara> StoryEventTopCharas { get; set; }
        public virtual DbSet<StoryEventWinBonu> StoryEventWinBonus { get; set; }
        public virtual DbSet<StoryLiveSet> StoryLiveSets { get; set; }
        public virtual DbSet<StoryStill> StoryStills { get; set; }
        public virtual DbSet<SuccessionFactor> SuccessionFactors { get; set; }
        public virtual DbSet<SuccessionFactorEffect> SuccessionFactorEffects { get; set; }
        public virtual DbSet<SuccessionInitialFactor> SuccessionInitialFactors { get; set; }
        public virtual DbSet<SuccessionRelation> SuccessionRelations { get; set; }
        public virtual DbSet<SuccessionRelationMember> SuccessionRelationMembers { get; set; }
        public virtual DbSet<SuccessionRelationRank> SuccessionRelationRanks { get; set; }
        public virtual DbSet<SuccessionRental> SuccessionRentals { get; set; }
        public virtual DbSet<SupportCardDatum> SupportCardData { get; set; }
        public virtual DbSet<SupportCardEffectTable> SupportCardEffectTables { get; set; }
        public virtual DbSet<SupportCardLevel> SupportCardLevels { get; set; }
        public virtual DbSet<SupportCardLimit> SupportCardLimits { get; set; }
        public virtual DbSet<SupportCardTeamScoreBonu> SupportCardTeamScoreBonus { get; set; }
        public virtual DbSet<SupportCardUniqueEffect> SupportCardUniqueEffects { get; set; }
        public virtual DbSet<TeamStadium> TeamStadia { get; set; }
        public virtual DbSet<TeamStadiumBgm> TeamStadiumBgms { get; set; }
        public virtual DbSet<TeamStadiumClass> TeamStadiumClasses { get; set; }
        public virtual DbSet<TeamStadiumClassReward> TeamStadiumClassRewards { get; set; }
        public virtual DbSet<TeamStadiumEvaluationRate> TeamStadiumEvaluationRates { get; set; }
        public virtual DbSet<TeamStadiumRaceResultMotion> TeamStadiumRaceResultMotions { get; set; }
        public virtual DbSet<TeamStadiumRank> TeamStadiumRanks { get; set; }
        public virtual DbSet<TeamStadiumRawScore> TeamStadiumRawScores { get; set; }
        public virtual DbSet<TeamStadiumScoreBonu> TeamStadiumScoreBonus { get; set; }
        public virtual DbSet<TeamStadiumStandMotion> TeamStadiumStandMotions { get; set; }
        public virtual DbSet<TeamStadiumSupportText> TeamStadiumSupportTexts { get; set; }
        public virtual DbSet<TextDatum> TextData { get; set; }
        public virtual DbSet<TimezoneDatum> TimezoneData { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<TrainedCharaTradeItem> TrainedCharaTradeItems { get; set; }
        public virtual DbSet<TrainingCuttCharaDatum> TrainingCuttCharaData { get; set; }
        public virtual DbSet<TrainingCuttDatum> TrainingCuttData { get; set; }
        public virtual DbSet<TutorialGuideDatum> TutorialGuideData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("data source=Model\\Master\\master.sqlite");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnnounceCharacter>(entity =>
            {
                entity.ToTable("announce_character");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MovieId).HasColumnName("movie_id");
            });

            modelBuilder.Entity<AnnounceDatum>(entity =>
            {
                entity.ToTable("announce_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AnnounceId).HasColumnName("announce_id");

                entity.Property(e => e.AnnounceType).HasColumnName("announce_type");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.StartDate).HasColumnName("start_date");
            });

            modelBuilder.Entity<AnnounceSupportCard>(entity =>
            {
                entity.ToTable("announce_support_card");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CutsPattern).HasColumnName("cuts_pattern");

                entity.Property(e => e.SupportCardIdA).HasColumnName("support_card_id_a");

                entity.Property(e => e.SupportCardIdB).HasColumnName("support_card_id_b");

                entity.Property(e => e.SupportCardIdC).HasColumnName("support_card_id_c");
            });

            modelBuilder.Entity<AudioCuesheet>(entity =>
            {
                entity.ToTable("audio_cuesheet");

                entity.HasIndex(e => e.Attribute, "audio_cuesheet_0_attribute");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Attribute).HasColumnName("attribute");

                entity.Property(e => e.CueSheet)
                    .IsRequired()
                    .HasColumnName("cue_sheet");
            });

            modelBuilder.Entity<AudioIgnoredCueOnHighspeed>(entity =>
            {
                entity.ToTable("audio_ignored_cue_on_highspeed");

                entity.HasIndex(e => new { e.CueName, e.CueSheet }, "audio_ignored_cue_on_highspeed_0_cue_name_1_cue_sheet");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnName("cue_name");

                entity.Property(e => e.CueSheet)
                    .IsRequired()
                    .HasColumnName("cue_sheet");
            });

            modelBuilder.Entity<AvailableSkillSet>(entity =>
            {
                entity.ToTable("available_skill_set");

                entity.HasIndex(e => e.AvailableSkillSetId, "available_skill_set_0_available_skill_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AvailableSkillSetId).HasColumnName("available_skill_set_id");

                entity.Property(e => e.NeedRank).HasColumnName("need_rank");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");
            });

            modelBuilder.Entity<BackgroundDatum>(entity =>
            {
                entity.ToTable("background_data");

                entity.HasIndex(e => new { e.BgId, e.BgSub }, "background_data_0_bg_id_1_bg_sub")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BgId).HasColumnName("bg_id");

                entity.Property(e => e.BgSub).HasColumnName("bg_sub");

                entity.Property(e => e.BusParamSetName)
                    .IsRequired()
                    .HasColumnName("bus_param_set_name");

                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnName("cue_name");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.PosX).HasColumnName("pos_x");

                entity.Property(e => e.PosY).HasColumnName("pos_y");

                entity.Property(e => e.SheetName)
                    .IsRequired()
                    .HasColumnName("sheet_name");

                entity.Property(e => e.Width).HasColumnName("width");
            });

            modelBuilder.Entity<BannerDatum>(entity =>
            {
                entity.ToTable("banner_data");

                entity.HasIndex(e => e.GroupId, "banner_data_0_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BannerId).HasColumnName("banner_id");

                entity.Property(e => e.ConditionValue).HasColumnName("condition_value");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnName("end_date");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("start_date");

                entity.Property(e => e.Transition).HasColumnName("transition");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<CampaignCharaStorySchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("campaign_chara_story_schedule");

                entity.HasIndex(e => e.CampaignId, "campaign_chara_story_schedule_0_campaign_id");

                entity.HasIndex(e => e.CharaId, "campaign_chara_story_schedule_0_chara_id");

                entity.Property(e => e.CampaignId).HasColumnName("campaign_id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.StoryId).HasColumnName("story_id");
            });

            modelBuilder.Entity<CampaignDatum>(entity =>
            {
                entity.HasKey(e => e.CampaignId);

                entity.ToTable("campaign_data");

                entity.HasIndex(e => e.TargetType, "campaign_data_0_target_type");

                entity.Property(e => e.CampaignId)
                    .ValueGeneratedNever()
                    .HasColumnName("campaign_id");

                entity.Property(e => e.EffectType1).HasColumnName("effect_type_1");

                entity.Property(e => e.EffectValue1).HasColumnName("effect_value_1");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.ImageIconId).HasColumnName("image_icon_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.TargetId).HasColumnName("target_id");

                entity.Property(e => e.TargetType).HasColumnName("target_type");

                entity.Property(e => e.TransitionType).HasColumnName("transition_type");

                entity.Property(e => e.UserShow).HasColumnName("user_show");
            });

            modelBuilder.Entity<CardDatum>(entity =>
            {
                entity.ToTable("card_data");

                entity.HasIndex(e => e.CharaId, "card_data_0_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AvailableSkillSetId).HasColumnName("available_skill_set_id");

                entity.Property(e => e.BgId).HasColumnName("bg_id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.DefaultRarity).HasColumnName("default_rarity");

                entity.Property(e => e.GetPieceId).HasColumnName("get_piece_id");

                entity.Property(e => e.LimitedChara).HasColumnName("limited_chara");

                entity.Property(e => e.RunningStyle).HasColumnName("running_style");

                entity.Property(e => e.TalentGroupId).HasColumnName("talent_group_id");

                entity.Property(e => e.TalentGuts).HasColumnName("talent_guts");

                entity.Property(e => e.TalentPow).HasColumnName("talent_pow");

                entity.Property(e => e.TalentSpeed).HasColumnName("talent_speed");

                entity.Property(e => e.TalentStamina).HasColumnName("talent_stamina");

                entity.Property(e => e.TalentWiz).HasColumnName("talent_wiz");
            });

            modelBuilder.Entity<CardRarityDatum>(entity =>
            {
                entity.ToTable("card_rarity_data");

                entity.HasIndex(e => e.CardId, "card_rarity_data_0_card_id");

                entity.HasIndex(e => new { e.CardId, e.Rarity }, "card_rarity_data_0_card_id_1_rarity")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CardId).HasColumnName("card_id");

                entity.Property(e => e.GetDressId1).HasColumnName("get_dress_id_1");

                entity.Property(e => e.GetDressId2).HasColumnName("get_dress_id_2");

                entity.Property(e => e.Guts).HasColumnName("guts");

                entity.Property(e => e.LiveDressId).HasColumnName("live_dress_id");

                entity.Property(e => e.MaxGuts).HasColumnName("max_guts");

                entity.Property(e => e.MaxPow).HasColumnName("max_pow");

                entity.Property(e => e.MaxSpeed).HasColumnName("max_speed");

                entity.Property(e => e.MaxStamina).HasColumnName("max_stamina");

                entity.Property(e => e.MaxWiz).HasColumnName("max_wiz");

                entity.Property(e => e.MiniDressId).HasColumnName("mini_dress_id");

                entity.Property(e => e.OutgameDressId).HasColumnName("outgame_dress_id");

                entity.Property(e => e.Pow).HasColumnName("pow");

                entity.Property(e => e.ProperDistanceLong).HasColumnName("proper_distance_long");

                entity.Property(e => e.ProperDistanceMiddle).HasColumnName("proper_distance_middle");

                entity.Property(e => e.ProperDistanceMile).HasColumnName("proper_distance_mile");

                entity.Property(e => e.ProperDistanceShort).HasColumnName("proper_distance_short");

                entity.Property(e => e.ProperGroundDirt).HasColumnName("proper_ground_dirt");

                entity.Property(e => e.ProperGroundTurf).HasColumnName("proper_ground_turf");

                entity.Property(e => e.ProperRunningStyleNige).HasColumnName("proper_running_style_nige");

                entity.Property(e => e.ProperRunningStyleOikomi).HasColumnName("proper_running_style_oikomi");

                entity.Property(e => e.ProperRunningStyleSashi).HasColumnName("proper_running_style_sashi");

                entity.Property(e => e.ProperRunningStyleSenko).HasColumnName("proper_running_style_senko");

                entity.Property(e => e.RaceDressId).HasColumnName("race_dress_id");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.SkillSet).HasColumnName("skill_set");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.Stamina).HasColumnName("stamina");

                entity.Property(e => e.Wiz).HasColumnName("wiz");
            });

            modelBuilder.Entity<CardTalentUpgrade>(entity =>
            {
                entity.ToTable("card_talent_upgrade");

                entity.HasIndex(e => new { e.TalentGroupId, e.TalentLevel }, "card_talent_upgrade_0_talent_group_id_1_talent_level");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ItemCategory1).HasColumnName("item_category_1");

                entity.Property(e => e.ItemCategory2).HasColumnName("item_category_2");

                entity.Property(e => e.ItemCategory3).HasColumnName("item_category_3");

                entity.Property(e => e.ItemCategory4).HasColumnName("item_category_4");

                entity.Property(e => e.ItemCategory5).HasColumnName("item_category_5");

                entity.Property(e => e.ItemCategory6).HasColumnName("item_category_6");

                entity.Property(e => e.ItemId1).HasColumnName("item_id_1");

                entity.Property(e => e.ItemId2).HasColumnName("item_id_2");

                entity.Property(e => e.ItemId3).HasColumnName("item_id_3");

                entity.Property(e => e.ItemId4).HasColumnName("item_id_4");

                entity.Property(e => e.ItemId5).HasColumnName("item_id_5");

                entity.Property(e => e.ItemId6).HasColumnName("item_id_6");

                entity.Property(e => e.ItemNum1).HasColumnName("item_num_1");

                entity.Property(e => e.ItemNum2).HasColumnName("item_num_2");

                entity.Property(e => e.ItemNum3).HasColumnName("item_num_3");

                entity.Property(e => e.ItemNum4).HasColumnName("item_num_4");

                entity.Property(e => e.ItemNum5).HasColumnName("item_num_5");

                entity.Property(e => e.ItemNum6).HasColumnName("item_num_6");

                entity.Property(e => e.TalentGroupId).HasColumnName("talent_group_id");

                entity.Property(e => e.TalentLevel).HasColumnName("talent_level");
            });

            modelBuilder.Entity<CharaCategoryMotion>(entity =>
            {
                entity.HasKey(e => e.CharaId);

                entity.ToTable("chara_category_motion");

                entity.Property(e => e.CharaId)
                    .ValueGeneratedNever()
                    .HasColumnName("chara_id");

                entity.Property(e => e.StandbyMotion1).HasColumnName("standby_motion_1");

                entity.Property(e => e.StandbyMotion2).HasColumnName("standby_motion_2");

                entity.Property(e => e.StandbyMotion3).HasColumnName("standby_motion_3");

                entity.Property(e => e.StandbyMotion4).HasColumnName("standby_motion_4");

                entity.Property(e => e.StandbyMotion5).HasColumnName("standby_motion_5");

                entity.Property(e => e.StandbyMotion6).HasColumnName("standby_motion_6");
            });

            modelBuilder.Entity<CharaDatum>(entity =>
            {
                entity.ToTable("chara_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AttachmentModelId).HasColumnName("attachment_model_id");

                entity.Property(e => e.BirthDay).HasColumnName("birth_day");

                entity.Property(e => e.BirthMonth).HasColumnName("birth_month");

                entity.Property(e => e.BirthYear).HasColumnName("birth_year");

                entity.Property(e => e.Bust).HasColumnName("bust");

                entity.Property(e => e.CharaCategory).HasColumnName("chara_category");

                entity.Property(e => e.EarRandomTimeMax).HasColumnName("ear_random_time_max");

                entity.Property(e => e.EarRandomTimeMin).HasColumnName("ear_random_time_min");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.ImageColorMain)
                    .IsRequired()
                    .HasColumnName("image_color_main");

                entity.Property(e => e.ImageColorSub)
                    .IsRequired()
                    .HasColumnName("image_color_sub");

                entity.Property(e => e.MiniMayuShaderType).HasColumnName("mini_mayu_shader_type");

                entity.Property(e => e.PersonalDress).HasColumnName("personal_dress");

                entity.Property(e => e.RaceRunningType).HasColumnName("race_running_type");

                entity.Property(e => e.Scale).HasColumnName("scale");

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.Property(e => e.Shape).HasColumnName("shape");

                entity.Property(e => e.Skin).HasColumnName("skin");

                entity.Property(e => e.Socks).HasColumnName("socks");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StoryEarRandomTimeMax).HasColumnName("story_ear_random_time_max");

                entity.Property(e => e.StoryEarRandomTimeMin).HasColumnName("story_ear_random_time_min");

                entity.Property(e => e.StoryTailRandomTimeMax).HasColumnName("story_tail_random_time_max");

                entity.Property(e => e.StoryTailRandomTimeMin).HasColumnName("story_tail_random_time_min");

                entity.Property(e => e.TailModelId).HasColumnName("tail_model_id");

                entity.Property(e => e.TailRandomTimeMax).HasColumnName("tail_random_time_max");

                entity.Property(e => e.TailRandomTimeMin).HasColumnName("tail_random_time_min");

                entity.Property(e => e.UiBorderColor)
                    .IsRequired()
                    .HasColumnName("ui_border_color");

                entity.Property(e => e.UiColorMain)
                    .IsRequired()
                    .HasColumnName("ui_color_main");

                entity.Property(e => e.UiColorSub)
                    .IsRequired()
                    .HasColumnName("ui_color_sub");

                entity.Property(e => e.UiNameplateColor1)
                    .IsRequired()
                    .HasColumnName("ui_nameplate_color_1");

                entity.Property(e => e.UiNameplateColor2)
                    .IsRequired()
                    .HasColumnName("ui_nameplate_color_2");

                entity.Property(e => e.UiNumColor1)
                    .IsRequired()
                    .HasColumnName("ui_num_color_1");

                entity.Property(e => e.UiNumColor2)
                    .IsRequired()
                    .HasColumnName("ui_num_color_2");

                entity.Property(e => e.UiSpeechColor1)
                    .IsRequired()
                    .HasColumnName("ui_speech_color_1");

                entity.Property(e => e.UiSpeechColor2)
                    .IsRequired()
                    .HasColumnName("ui_speech_color_2");

                entity.Property(e => e.UiTrainingColor1)
                    .IsRequired()
                    .HasColumnName("ui_training_color_1");

                entity.Property(e => e.UiTrainingColor2)
                    .IsRequired()
                    .HasColumnName("ui_training_color_2");

                entity.Property(e => e.UiTurnColor)
                    .IsRequired()
                    .HasColumnName("ui_turn_color");

                entity.Property(e => e.UiWipeColor1)
                    .IsRequired()
                    .HasColumnName("ui_wipe_color_1");

                entity.Property(e => e.UiWipeColor2)
                    .IsRequired()
                    .HasColumnName("ui_wipe_color_2");

                entity.Property(e => e.UiWipeColor3)
                    .IsRequired()
                    .HasColumnName("ui_wipe_color_3");
            });

            modelBuilder.Entity<CharaMotionAct>(entity =>
            {
                entity.ToTable("chara_motion_act");

                entity.HasIndex(e => e.CharaId, "chara_motion_act_0_chara_id");

                entity.HasIndex(e => new { e.CharaId, e.CommandName }, "chara_motion_act_0_chara_id_1_command_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.CommandName)
                    .IsRequired()
                    .HasColumnName("command_name");

                entity.Property(e => e.TargetMotion).HasColumnName("target_motion");
            });

            modelBuilder.Entity<CharaMotionSet>(entity =>
            {
                entity.ToTable("chara_motion_set");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BodyMotion)
                    .IsRequired()
                    .HasColumnName("body_motion");

                entity.Property(e => e.BodyMotionPlayType).HasColumnName("body_motion_play_type");

                entity.Property(e => e.BodyMotionType).HasColumnName("body_motion_type");

                entity.Property(e => e.Cheek).HasColumnName("cheek");

                entity.Property(e => e.EarMotion)
                    .IsRequired()
                    .HasColumnName("ear_motion");

                entity.Property(e => e.EyeDefault).HasColumnName("eye_default");

                entity.Property(e => e.FaceType)
                    .IsRequired()
                    .HasColumnName("face_type");

                entity.Property(e => e.TailMotion)
                    .IsRequired()
                    .HasColumnName("tail_motion");

                entity.Property(e => e.TailMotionType).HasColumnName("tail_motion_type");
            });

            modelBuilder.Entity<CharaStoryDatum>(entity =>
            {
                entity.ToTable("chara_story_data");

                entity.HasIndex(e => e.CharaId, "chara_story_data_0_chara_id");

                entity.HasIndex(e => new { e.CharaId, e.EpisodeIndex }, "chara_story_data_0_chara_id_1_episode_index");

                entity.HasIndex(e => e.StoryId, "chara_story_data_0_story_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AddRewardCategory1).HasColumnName("add_reward_category_1");

                entity.Property(e => e.AddRewardId1).HasColumnName("add_reward_id_1");

                entity.Property(e => e.AddRewardNum1).HasColumnName("add_reward_num_1");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.EpisodeIndex).HasColumnName("episode_index");

                entity.Property(e => e.ExpType).HasColumnName("exp_type");

                entity.Property(e => e.LockType1).HasColumnName("lock_type_1");

                entity.Property(e => e.LockValue11).HasColumnName("lock_value_1_1");

                entity.Property(e => e.LockValue12).HasColumnName("lock_value_1_2");

                entity.Property(e => e.StoryId).HasColumnName("story_id");
            });

            modelBuilder.Entity<CharaType>(entity =>
            {
                entity.ToTable("chara_type");

                entity.HasIndex(e => new { e.TargetScene, e.TargetCut }, "chara_type_0_target_scene_1_target_cut");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.TargetCut).HasColumnName("target_cut");

                entity.Property(e => e.TargetScene).HasColumnName("target_scene");

                entity.Property(e => e.TargetType).HasColumnName("target_type");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<CharacterPropAnimation>(entity =>
            {
                entity.ToTable("character_prop_animation");

                entity.HasIndex(e => new { e.PropId, e.SceneType }, "character_prop_animation_0_prop_id_1_scene_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.LayerIndex).HasColumnName("layer_index");

                entity.Property(e => e.PropAnimId).HasColumnName("prop_anim_id");

                entity.Property(e => e.PropId).HasColumnName("prop_id");

                entity.Property(e => e.SceneType).HasColumnName("scene_type");

                entity.Property(e => e.UseStateName)
                    .IsRequired()
                    .HasColumnName("use_state_name");
            });

            modelBuilder.Entity<CharacterSystemLottery>(entity =>
            {
                entity.ToTable("character_system_lottery");

                entity.HasIndex(e => e.CharaId, "character_system_lottery_0_chara_id");

                entity.HasIndex(e => new { e.CharaId, e.Trigger }, "character_system_lottery_0_chara_id_1_trigger");

                entity.HasIndex(e => new { e.Trigger, e.Param1 }, "character_system_lottery_0_trigger_1_param1");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CardId).HasColumnName("card_id");

                entity.Property(e => e.CardRarityId).HasColumnName("card_rarity_id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.Param1).HasColumnName("param1");

                entity.Property(e => e.Per).HasColumnName("per");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.SysTextId).HasColumnName("sys_text_id");

                entity.Property(e => e.Trigger).HasColumnName("trigger");
            });

            modelBuilder.Entity<CharacterSystemText>(entity =>
            {
                entity.HasKey(e => new { e.CharacterId, e.VoiceId });

                entity.ToTable("character_system_text");

                entity.HasIndex(e => e.CharacterId, "character_system_text_0_character_id");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");

                entity.Property(e => e.CardId).HasColumnName("card_id");

                entity.Property(e => e.CueId).HasColumnName("cue_id");

                entity.Property(e => e.CueSheet)
                    .IsRequired()
                    .HasColumnName("cue_sheet");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.LipSyncData)
                    .IsRequired()
                    .HasColumnName("lip_sync_data");

                entity.Property(e => e.MotionSecondSet).HasColumnName("motion_second_set");

                entity.Property(e => e.MotionSecondStart).HasColumnName("motion_second_start");

                entity.Property(e => e.MotionSet).HasColumnName("motion_set");

                entity.Property(e => e.Scene).HasColumnName("scene");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");

                entity.Property(e => e.UseGallery).HasColumnName("use_gallery");
            });

            modelBuilder.Entity<CircleRankDatum>(entity =>
            {
                entity.ToTable("circle_rank_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.NeedRankingMax).HasColumnName("need_ranking_max");

                entity.Property(e => e.NeedRankingMin).HasColumnName("need_ranking_min");

                entity.Property(e => e.RewardItemCategory1).HasColumnName("reward_item_category_1");

                entity.Property(e => e.RewardItemCategory2).HasColumnName("reward_item_category_2");

                entity.Property(e => e.RewardItemId1).HasColumnName("reward_item_id_1");

                entity.Property(e => e.RewardItemId2).HasColumnName("reward_item_id_2");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");
            });

            modelBuilder.Entity<CircleStampDatum>(entity =>
            {
                entity.ToTable("circle_stamp_data");

                entity.HasIndex(e => e.DispOrder, "IX_circle_stamp_data_disp_order")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<CraneGameArmSwing>(entity =>
            {
                entity.HasKey(e => e.ResultType);

                entity.ToTable("crane_game_arm_swing");

                entity.Property(e => e.ResultType)
                    .ValueGeneratedNever()
                    .HasColumnName("result_type");

                entity.Property(e => e.Odds1).HasColumnName("odds_1");

                entity.Property(e => e.Odds2).HasColumnName("odds_2");

                entity.Property(e => e.Odds3).HasColumnName("odds_3");
            });

            modelBuilder.Entity<CraneGameCatchResult>(entity =>
            {
                entity.HasKey(e => new { e.OddsId, e.GetNum });

                entity.ToTable("crane_game_catch_result");

                entity.Property(e => e.OddsId).HasColumnName("odds_id");

                entity.Property(e => e.GetNum).HasColumnName("get_num");

                entity.Property(e => e.LotteryWeight11).HasColumnName("lottery_weight_1_1");

                entity.Property(e => e.LotteryWeight12).HasColumnName("lottery_weight_1_2");

                entity.Property(e => e.LotteryWeight21).HasColumnName("lottery_weight_2_1");

                entity.Property(e => e.LotteryWeight22).HasColumnName("lottery_weight_2_2");

                entity.Property(e => e.LotteryWeight31).HasColumnName("lottery_weight_3_1");

                entity.Property(e => e.LotteryWeight32).HasColumnName("lottery_weight_3_2");

                entity.Property(e => e.LotteryWeightExtra1).HasColumnName("lottery_weight_extra_1");

                entity.Property(e => e.LotteryWeightExtra2).HasColumnName("lottery_weight_extra_2");
            });

            modelBuilder.Entity<CraneGameDefineParam>(entity =>
            {
                entity.ToTable("crane_game_define_param");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Distance1)
                    .IsRequired()
                    .HasColumnName("distance1");

                entity.Property(e => e.Distance2)
                    .IsRequired()
                    .HasColumnName("distance2");

                entity.Property(e => e.MoveSpeed1)
                    .IsRequired()
                    .HasColumnName("move_speed_1");

                entity.Property(e => e.MoveSpeed2)
                    .IsRequired()
                    .HasColumnName("move_speed_2");

                entity.Property(e => e.MoveSpeed3)
                    .IsRequired()
                    .HasColumnName("move_speed_3");
            });

            modelBuilder.Entity<CraneGameExtraOddsCondition>(entity =>
            {
                entity.HasKey(e => e.Credit);

                entity.ToTable("crane_game_extra_odds_condition");

                entity.Property(e => e.Credit)
                    .ValueGeneratedNever()
                    .HasColumnName("credit");

                entity.Property(e => e.GetNum).HasColumnName("get_num");
            });

            modelBuilder.Entity<CraneGameHiddenOdd>(entity =>
            {
                entity.ToTable("crane_game_hidden_odds");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AnimationId).HasColumnName("animation_id");

                entity.Property(e => e.Big).HasColumnName("big");

                entity.Property(e => e.BigIndex).HasColumnName("big_index");

                entity.Property(e => e.CraneAnimationId).HasColumnName("crane_animation_id");

                entity.Property(e => e.JointType).HasColumnName("joint_type");

                entity.Property(e => e.LiftType).HasColumnName("lift_type");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.Odds1).HasColumnName("odds_1");

                entity.Property(e => e.Odds2).HasColumnName("odds_2");

                entity.Property(e => e.Odds3).HasColumnName("odds_3");

                entity.Property(e => e.OddsExtra).HasColumnName("odds_extra");

                entity.Property(e => e.PushType).HasColumnName("push_type");

                entity.Property(e => e.RareEffectOdds).HasColumnName("rare_effect_odds");

                entity.Property(e => e.TypeId).HasColumnName("type_id");
            });

            modelBuilder.Entity<CraneGamePrizeFace>(entity =>
            {
                entity.ToTable("crane_game_prize_face");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FaceType)
                    .IsRequired()
                    .HasColumnName("face_type");
            });

            modelBuilder.Entity<CraneGamePrizePattern>(entity =>
            {
                entity.ToTable("crane_game_prize_pattern");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.PropPatternId).HasColumnName("prop_pattern_id");
            });

            modelBuilder.Entity<CraneGameProp>(entity =>
            {
                entity.HasKey(e => e.Type);

                entity.ToTable("crane_game_prop");

                entity.Property(e => e.Type)
                    .ValueGeneratedNever()
                    .HasColumnName("type");

                entity.Property(e => e.Num).HasColumnName("num");
            });

            modelBuilder.Entity<DailyPack>(entity =>
            {
                entity.HasKey(e => new { e.ShopDataId, e.PlatformId });

                entity.ToTable("daily_pack");

                entity.HasIndex(e => e.GroupId, "daily_pack_0_group_id");

                entity.Property(e => e.ShopDataId).HasColumnName("shop_data_id");

                entity.Property(e => e.PlatformId).HasColumnName("platform_id");

                entity.Property(e => e.DailyFreeNum).HasColumnName("daily_free_num");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnName("end_date");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.RepurchaseDay).HasColumnName("repurchase_day");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("start_date");

                entity.Property(e => e.Term).HasColumnName("term");
            });

            modelBuilder.Entity<DailyRace>(entity =>
            {
                entity.ToTable("daily_race");

                entity.HasIndex(e => e.RaceInstanceId, "daily_race_0_race_instance_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CostNum).HasColumnName("cost_num");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.FirstClearItemCategory1).HasColumnName("first_clear_item_category_1");

                entity.Property(e => e.FirstClearItemCategory2).HasColumnName("first_clear_item_category_2");

                entity.Property(e => e.FirstClearItemCategory3).HasColumnName("first_clear_item_category_3");

                entity.Property(e => e.FirstClearItemId1).HasColumnName("first_clear_item_id_1");

                entity.Property(e => e.FirstClearItemId2).HasColumnName("first_clear_item_id_2");

                entity.Property(e => e.FirstClearItemId3).HasColumnName("first_clear_item_id_3");

                entity.Property(e => e.FirstClearItemNum1).HasColumnName("first_clear_item_num_1");

                entity.Property(e => e.FirstClearItemNum2).HasColumnName("first_clear_item_num_2");

                entity.Property(e => e.FirstClearItemNum3).HasColumnName("first_clear_item_num_3");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.NormalRewardsOddsId).HasColumnName("normal_rewards_odds_id");

                entity.Property(e => e.PickUpItemCategory1).HasColumnName("pick_up_item_category_1");

                entity.Property(e => e.PickUpItemCategory2).HasColumnName("pick_up_item_category_2");

                entity.Property(e => e.PickUpItemCategory3).HasColumnName("pick_up_item_category_3");

                entity.Property(e => e.PickUpItemId1).HasColumnName("pick_up_item_id_1");

                entity.Property(e => e.PickUpItemId2).HasColumnName("pick_up_item_id_2");

                entity.Property(e => e.PickUpItemId3).HasColumnName("pick_up_item_id_3");

                entity.Property(e => e.PickUpItemNum1).HasColumnName("pick_up_item_num_1");

                entity.Property(e => e.PickUpItemNum2).HasColumnName("pick_up_item_num_2");

                entity.Property(e => e.PickUpItemNum3).HasColumnName("pick_up_item_num_3");

                entity.Property(e => e.RaceInstanceId).HasColumnName("race_instance_id");

                entity.Property(e => e.RareRewardOddsId).HasColumnName("rare_reward_odds_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.UniqueCharaNpcMax).HasColumnName("unique_chara_npc_max");

                entity.Property(e => e.UniqueCharaNpcMin).HasColumnName("unique_chara_npc_min");
            });

            modelBuilder.Entity<DailyRaceBilling>(entity =>
            {
                entity.ToTable("daily_race_billing");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Frequency).HasColumnName("frequency");

                entity.Property(e => e.PayCost).HasColumnName("pay_cost");
            });

            modelBuilder.Entity<DailyRaceNpc>(entity =>
            {
                entity.ToTable("daily_race_npc");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.Guts).HasColumnName("guts");

                entity.Property(e => e.MobId).HasColumnName("mob_id");

                entity.Property(e => e.NpcGroupId).HasColumnName("npc_group_id");

                entity.Property(e => e.Pow).HasColumnName("pow");

                entity.Property(e => e.ProperDistanceLong).HasColumnName("proper_distance_long");

                entity.Property(e => e.ProperDistanceMiddle).HasColumnName("proper_distance_middle");

                entity.Property(e => e.ProperDistanceMile).HasColumnName("proper_distance_mile");

                entity.Property(e => e.ProperDistanceShort).HasColumnName("proper_distance_short");

                entity.Property(e => e.ProperGroundDirt).HasColumnName("proper_ground_dirt");

                entity.Property(e => e.ProperGroundTurf).HasColumnName("proper_ground_turf");

                entity.Property(e => e.ProperRunningStyleNige).HasColumnName("proper_running_style_nige");

                entity.Property(e => e.ProperRunningStyleOikomi).HasColumnName("proper_running_style_oikomi");

                entity.Property(e => e.ProperRunningStyleSashi).HasColumnName("proper_running_style_sashi");

                entity.Property(e => e.ProperRunningStyleSenko).HasColumnName("proper_running_style_senko");

                entity.Property(e => e.RaceDressId).HasColumnName("race_dress_id");

                entity.Property(e => e.RaceInstanceId).HasColumnName("race_instance_id");

                entity.Property(e => e.SkillSetId).HasColumnName("skill_set_id");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.Stamina).HasColumnName("stamina");

                entity.Property(e => e.Wiz).HasColumnName("wiz");
            });

            modelBuilder.Entity<Directory>(entity =>
            {
                entity.ToTable("directory");

                entity.HasIndex(e => e.RankLevel, "directory_0_rank_level")
                    .IsUnique();

                entity.HasIndex(e => e.RequiredPoint, "directory_0_required_point");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ItemCategory1).HasColumnName("item_category_1");

                entity.Property(e => e.ItemId1).HasColumnName("item_id_1");

                entity.Property(e => e.ItemNum1).HasColumnName("item_num_1");

                entity.Property(e => e.RankLevel).HasColumnName("rank_level");

                entity.Property(e => e.RequiredPoint).HasColumnName("required_point");
            });

            modelBuilder.Entity<DressDatum>(entity =>
            {
                entity.ToTable("dress_data");

                entity.HasIndex(e => e.BodyType, "dress_data_0_body_type");

                entity.HasIndex(e => e.CharaId, "dress_data_0_chara_id");

                entity.HasIndex(e => e.ConditionType, "dress_data_0_condition_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BodySetting).HasColumnName("body_setting");

                entity.Property(e => e.BodyType).HasColumnName("body_type");

                entity.Property(e => e.BodyTypeSub).HasColumnName("body_type_sub");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.ColorNum).HasColumnName("color_num");

                entity.Property(e => e.ConditionType).HasColumnName("condition_type");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.DressColorMain)
                    .IsRequired()
                    .HasColumnName("dress_color_main");

                entity.Property(e => e.DressColorSub)
                    .IsRequired()
                    .HasColumnName("dress_color_sub");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.HaveMini).HasColumnName("have_mini");

                entity.Property(e => e.HeadSubId).HasColumnName("head_sub_id");

                entity.Property(e => e.IsDirt).HasColumnName("is_dirt");

                entity.Property(e => e.IsWet).HasColumnName("is_wet");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.TailModelId).HasColumnName("tail_model_id");

                entity.Property(e => e.TailModelSubId).HasColumnName("tail_model_sub_id");

                entity.Property(e => e.UseGender).HasColumnName("use_gender");

                entity.Property(e => e.UseHome).HasColumnName("use_home");

                entity.Property(e => e.UseLive).HasColumnName("use_live");

                entity.Property(e => e.UseLiveTheater).HasColumnName("use_live_theater");

                entity.Property(e => e.UseRace).HasColumnName("use_race");

                entity.Property(e => e.UseSeason).HasColumnName("use_season");
            });

            modelBuilder.Entity<EventMotionDatum>(entity =>
            {
                entity.ToTable("event_motion_data");

                entity.HasIndex(e => e.Type, "event_motion_data_0_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BaseStateName)
                    .IsRequired()
                    .HasColumnName("base_state_name");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.CommandName)
                    .IsRequired()
                    .HasColumnName("command_name");

                entity.Property(e => e.EndBlendTime).HasColumnName("end_blend_time");

                entity.Property(e => e.PoseBlend).HasColumnName("pose_blend");

                entity.Property(e => e.StartBlendTime).HasColumnName("start_blend_time");

                entity.Property(e => e.StateGroup).HasColumnName("state_group");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<EventMotionPlusDatum>(entity =>
            {
                entity.ToTable("event_motion_plus_data");

                entity.HasIndex(e => e.BaseStateName, "event_motion_plus_data_0_base_state_name");

                entity.HasIndex(e => e.LayerIndex, "event_motion_plus_data_0_layer_index");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BaseStateName)
                    .IsRequired()
                    .HasColumnName("base_state_name");

                entity.Property(e => e.CommandName)
                    .IsRequired()
                    .HasColumnName("command_name");

                entity.Property(e => e.EndBlendTime).HasColumnName("end_blend_time");

                entity.Property(e => e.LayerIndex).HasColumnName("layer_index");

                entity.Property(e => e.StartBlendTime).HasColumnName("start_blend_time");

                entity.Property(e => e.TailMotionType).HasColumnName("tail_motion_type");
            });

            modelBuilder.Entity<FaceTypeDatum>(entity =>
            {
                entity.HasKey(e => e.Label);

                entity.ToTable("face_type_data");

                entity.Property(e => e.Label).HasColumnName("label");

                entity.Property(e => e.EyeL)
                    .IsRequired()
                    .HasColumnName("eye_l");

                entity.Property(e => e.EyeR)
                    .IsRequired()
                    .HasColumnName("eye_r");

                entity.Property(e => e.EyebrowL)
                    .IsRequired()
                    .HasColumnName("eyebrow_l");

                entity.Property(e => e.EyebrowR)
                    .IsRequired()
                    .HasColumnName("eyebrow_r");

                entity.Property(e => e.InverceFaceType)
                    .IsRequired()
                    .HasColumnName("inverce_face_type");

                entity.Property(e => e.Mouth)
                    .IsRequired()
                    .HasColumnName("mouth");

                entity.Property(e => e.MouthShapeType).HasColumnName("mouth_shape_type");

                entity.Property(e => e.SetFaceGroup).HasColumnName("set_face_group");
            });

            modelBuilder.Entity<FacialMouthChange>(entity =>
            {
                entity.ToTable("facial_mouth_change");

                entity.HasIndex(e => e.CharaId, "facial_mouth_change_0_chara_id");

                entity.HasIndex(e => new { e.CharaId, e.BeforeFacialname }, "facial_mouth_change_0_chara_id_1_before_facialname")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AfterFacialname)
                    .IsRequired()
                    .HasColumnName("after_facialname");

                entity.Property(e => e.BeforeFacialname)
                    .IsRequired()
                    .HasColumnName("before_facialname");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");
            });

            modelBuilder.Entity<GachaAvailable>(entity =>
            {
                entity.HasKey(e => new { e.GachaId, e.CardId });

                entity.ToTable("gacha_available");

                entity.HasIndex(e => e.GachaId, "gacha_available_0_gacha_id");

                entity.Property(e => e.GachaId).HasColumnName("gacha_id");

                entity.Property(e => e.CardId).HasColumnName("card_id");

                entity.Property(e => e.CardType).HasColumnName("card_type");

                entity.Property(e => e.IsPickup).HasColumnName("is_pickup");

                entity.Property(e => e.IsPrizeSelectable).HasColumnName("is_prize_selectable");

                entity.Property(e => e.Odds).HasColumnName("odds");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.RecommendOrder).HasColumnName("recommend_order");
            });

            modelBuilder.Entity<GachaDatum>(entity =>
            {
                entity.ToTable("gacha_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AdditionalPieceNum1).HasColumnName("additional_piece_num_1");

                entity.Property(e => e.AdditionalPieceNum2).HasColumnName("additional_piece_num_2");

                entity.Property(e => e.AdditionalPieceNum3).HasColumnName("additional_piece_num_3");

                entity.Property(e => e.AdditionalPieceNum4).HasColumnName("additional_piece_num_4");

                entity.Property(e => e.AdditionalPieceNum5).HasColumnName("additional_piece_num_5");

                entity.Property(e => e.AdditionalPieceNum6).HasColumnName("additional_piece_num_6");

                entity.Property(e => e.AdditionalPieceTargetCardId1).HasColumnName("additional_piece_target_card_id_1");

                entity.Property(e => e.AdditionalPieceTargetCardId2).HasColumnName("additional_piece_target_card_id_2");

                entity.Property(e => e.AdditionalPieceTargetCardId3).HasColumnName("additional_piece_target_card_id_3");

                entity.Property(e => e.AdditionalPieceTargetCardId4).HasColumnName("additional_piece_target_card_id_4");

                entity.Property(e => e.AdditionalPieceTargetCardId5).HasColumnName("additional_piece_target_card_id_5");

                entity.Property(e => e.AdditionalPieceTargetCardId6).HasColumnName("additional_piece_target_card_id_6");

                entity.Property(e => e.AdditionalPieceTargetCardType1).HasColumnName("additional_piece_target_card_type_1");

                entity.Property(e => e.AdditionalPieceTargetCardType2).HasColumnName("additional_piece_target_card_type_2");

                entity.Property(e => e.AdditionalPieceTargetCardType3).HasColumnName("additional_piece_target_card_type_3");

                entity.Property(e => e.AdditionalPieceTargetCardType4).HasColumnName("additional_piece_target_card_type_4");

                entity.Property(e => e.AdditionalPieceTargetCardType5).HasColumnName("additional_piece_target_card_type_5");

                entity.Property(e => e.AdditionalPieceTargetCardType6).HasColumnName("additional_piece_target_card_type_6");

                entity.Property(e => e.AdditionalPieceTargetRarity1).HasColumnName("additional_piece_target_rarity_1");

                entity.Property(e => e.AdditionalPieceTargetRarity2).HasColumnName("additional_piece_target_rarity_2");

                entity.Property(e => e.AdditionalPieceTargetRarity3).HasColumnName("additional_piece_target_rarity_3");

                entity.Property(e => e.AdditionalPieceTargetRarity4).HasColumnName("additional_piece_target_rarity_4");

                entity.Property(e => e.AdditionalPieceTargetRarity5).HasColumnName("additional_piece_target_rarity_5");

                entity.Property(e => e.AdditionalPieceTargetRarity6).HasColumnName("additional_piece_target_rarity_6");

                entity.Property(e => e.BonusItemCategory1).HasColumnName("bonus_item_category_1");

                entity.Property(e => e.BonusItemCategory2).HasColumnName("bonus_item_category_2");

                entity.Property(e => e.BonusItemId1).HasColumnName("bonus_item_id_1");

                entity.Property(e => e.BonusItemId2).HasColumnName("bonus_item_id_2");

                entity.Property(e => e.BonusItemNum1).HasColumnName("bonus_item_num_1");

                entity.Property(e => e.BonusItemNum2).HasColumnName("bonus_item_num_2");

                entity.Property(e => e.BonusTargetDrawNum).HasColumnName("bonus_target_draw_num");

                entity.Property(e => e.CardType).HasColumnName("card_type");

                entity.Property(e => e.CostSingle).HasColumnName("cost_single");

                entity.Property(e => e.CostType).HasColumnName("cost_type");

                entity.Property(e => e.DailyPayCost).HasColumnName("daily_pay_cost");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.DrawGuaranteeNum).HasColumnName("draw_guarantee_num");

                entity.Property(e => e.DrawGuaranteeRarity).HasColumnName("draw_guarantee_rarity");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.OnlyOnceFlag).HasColumnName("only_once_flag");

                entity.Property(e => e.PrizeOddsId).HasColumnName("prize_odds_id");

                entity.Property(e => e.RarityOddsId).HasColumnName("rarity_odds_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<GachaExchange>(entity =>
            {
                entity.HasKey(e => new { e.GachaId, e.CardId });

                entity.ToTable("gacha_exchange");

                entity.HasIndex(e => e.GachaId, "gacha_exchange_0_gacha_id");

                entity.Property(e => e.GachaId).HasColumnName("gacha_id");

                entity.Property(e => e.CardId).HasColumnName("card_id");

                entity.Property(e => e.CardType).HasColumnName("card_type");

                entity.Property(e => e.PayItemNum).HasColumnName("pay_item_num");
            });

            modelBuilder.Entity<GachaFreeCampaign>(entity =>
            {
                entity.ToTable("gacha_free_campaign");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.GachaId).HasColumnName("gacha_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.TargetDrawType).HasColumnName("target_draw_type");
            });

            modelBuilder.Entity<GachaPiece>(entity =>
            {
                entity.ToTable("gacha_piece");

                entity.HasIndex(e => e.Rarity, "gacha_piece_0_rarity");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ItemCategory).HasColumnName("item_category");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.PieceNum).HasColumnName("piece_num");

                entity.Property(e => e.PieceType).HasColumnName("piece_type");

                entity.Property(e => e.Rarity).HasColumnName("rarity");
            });

            modelBuilder.Entity<GachaPrizeOdd>(entity =>
            {
                entity.HasKey(e => new { e.PrizeOddsId, e.Place });

                entity.ToTable("gacha_prize_odds");

                entity.HasIndex(e => e.PrizeOddsId, "gacha_prize_odds_0_prize_odds_id");

                entity.Property(e => e.PrizeOddsId).HasColumnName("prize_odds_id");

                entity.Property(e => e.Place).HasColumnName("place");

                entity.Property(e => e.ItemCategory1).HasColumnName("item_category_1");

                entity.Property(e => e.ItemCategory2).HasColumnName("item_category_2");

                entity.Property(e => e.ItemCategory3).HasColumnName("item_category_3");

                entity.Property(e => e.ItemCategory4).HasColumnName("item_category_4");

                entity.Property(e => e.ItemCategory5).HasColumnName("item_category_5");

                entity.Property(e => e.ItemCategory6).HasColumnName("item_category_6");

                entity.Property(e => e.ItemId1).HasColumnName("item_id_1");

                entity.Property(e => e.ItemId2).HasColumnName("item_id_2");

                entity.Property(e => e.ItemId3).HasColumnName("item_id_3");

                entity.Property(e => e.ItemId4).HasColumnName("item_id_4");

                entity.Property(e => e.ItemId5).HasColumnName("item_id_5");

                entity.Property(e => e.ItemId6).HasColumnName("item_id_6");

                entity.Property(e => e.ItemNum1).HasColumnName("item_num_1");

                entity.Property(e => e.ItemNum2).HasColumnName("item_num_2");

                entity.Property(e => e.ItemNum3).HasColumnName("item_num_3");

                entity.Property(e => e.ItemNum4).HasColumnName("item_num_4");

                entity.Property(e => e.ItemNum5).HasColumnName("item_num_5");

                entity.Property(e => e.ItemNum6).HasColumnName("item_num_6");

                entity.Property(e => e.Odds).HasColumnName("odds");

                entity.Property(e => e.PieceNum).HasColumnName("piece_num");
            });

            modelBuilder.Entity<GachaTopBg>(entity =>
            {
                entity.ToTable("gacha_top_bg");

                entity.HasIndex(e => e.GachaId, "gacha_top_bg_0_gacha_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GachaId).HasColumnName("gacha_id");
            });

            modelBuilder.Entity<GiftMessage>(entity =>
            {
                entity.ToTable("gift_message");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Type1).HasColumnName("type_1");

                entity.Property(e => e.Type2).HasColumnName("type_2");

                entity.Property(e => e.Type3).HasColumnName("type_3");

                entity.Property(e => e.Type4).HasColumnName("type_4");
            });

            modelBuilder.Entity<HighlightInterpolate>(entity =>
            {
                entity.ToTable("highlight_interpolate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.InTime).HasColumnName("in_time");

                entity.Property(e => e.OutTime).HasColumnName("out_time");
            });

            modelBuilder.Entity<HomeCharacterType>(entity =>
            {
                entity.HasKey(e => new { e.PosId, e.OriginalPersonality });

                entity.ToTable("home_character_type");

                entity.Property(e => e.PosId).HasColumnName("pos_id");

                entity.Property(e => e.OriginalPersonality).HasColumnName("original_personality");

                entity.Property(e => e.ChangePersonality).HasColumnName("change_personality");
            });

            modelBuilder.Entity<HomeEnvSetting>(entity =>
            {
                entity.ToTable("home_env_setting");

                entity.HasIndex(e => new { e.HomeSetId, e.HomeEventType, e.Season, e.Weather, e.Timezone }, "home_env_setting_0_home_set_id_1_home_event_type_2_season_3_weather_4_timezone")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name");

                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name");

                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnName("env_cue_name");

                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnName("env_cuesheet_name");

                entity.Property(e => e.HomeEventType).HasColumnName("home_event_type");

                entity.Property(e => e.HomeSetId).HasColumnName("home_set_id");

                entity.Property(e => e.Resource).HasColumnName("resource");

                entity.Property(e => e.ResourceEventCheck).HasColumnName("resource_event_check");

                entity.Property(e => e.Season).HasColumnName("season");

                entity.Property(e => e.Timezone).HasColumnName("timezone");

                entity.Property(e => e.Weather).HasColumnName("weather");
            });

            modelBuilder.Entity<HomePosterDatum>(entity =>
            {
                entity.ToTable("home_poster_data");

                entity.HasIndex(e => e.Priority, "home_poster_data_0_priority");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DetailValue).HasColumnName("detail_value");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.PosiHorizontal).HasColumnName("posi_horizontal");

                entity.Property(e => e.PosiVertical).HasColumnName("posi_vertical");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url");

                entity.Property(e => e.UrlValue).HasColumnName("url_value");

                entity.Property(e => e.Width).HasColumnName("width");
            });

            modelBuilder.Entity<HomePropSetting>(entity =>
            {
                entity.HasKey(e => new { e.PosId, e.Personality });

                entity.ToTable("home_prop_setting");

                entity.Property(e => e.PosId).HasColumnName("pos_id");

                entity.Property(e => e.Personality).HasColumnName("personality");

                entity.Property(e => e.AttachNode).HasColumnName("attach_node");

                entity.Property(e => e.PropId).HasColumnName("prop_id");
            });

            modelBuilder.Entity<HomeStoryTrigger>(entity =>
            {
                entity.ToTable("home_story_trigger");

                entity.HasIndex(e => new { e.HomeEventType, e.StoryId }, "home_story_trigger_0_home_event_type_1_story_id");

                entity.HasIndex(e => e.PosId, "home_story_trigger_0_pos_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId1).HasColumnName("chara_id_1");

                entity.Property(e => e.CharaId2).HasColumnName("chara_id_2");

                entity.Property(e => e.CharaId3).HasColumnName("chara_id_3");

                entity.Property(e => e.ConditionType).HasColumnName("condition_type");

                entity.Property(e => e.HomeEventType).HasColumnName("home_event_type");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.PosId).HasColumnName("pos_id");

                entity.Property(e => e.StoryId).HasColumnName("story_id");
            });

            modelBuilder.Entity<HomeWalkGroup>(entity =>
            {
                entity.ToTable("home_walk_group");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId1).HasColumnName("chara_id_1");

                entity.Property(e => e.CharaId2).HasColumnName("chara_id_2");

                entity.Property(e => e.CharaId3).HasColumnName("chara_id_3");
            });

            modelBuilder.Entity<HonorDatum>(entity =>
            {
                entity.ToTable("honor_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.ConditionType).HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue).HasColumnName("condition_value");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnName("end_date");

                entity.Property(e => e.Rank).HasColumnName("rank");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("start_date");

                entity.Property(e => e.StepGroupId).HasColumnName("step_group_id");

                entity.Property(e => e.StepOrder).HasColumnName("step_order");
            });

            modelBuilder.Entity<ItemDatum>(entity =>
            {
                entity.ToTable("item_data");

                entity.HasIndex(e => e.GroupId, "item_data_0_group_id");

                entity.HasIndex(e => e.ItemCategory, "item_data_0_item_category");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AddValue1).HasColumnName("add_value_1");

                entity.Property(e => e.AddValue2).HasColumnName("add_value_2");

                entity.Property(e => e.AddValue3).HasColumnName("add_value_3");

                entity.Property(e => e.EffectTarget1).HasColumnName("effect_target_1");

                entity.Property(e => e.EffectTarget2).HasColumnName("effect_target_2");

                entity.Property(e => e.EffectType1).HasColumnName("effect_type_1");

                entity.Property(e => e.EffectType2).HasColumnName("effect_type_2");

                entity.Property(e => e.EffectValue1).HasColumnName("effect_value_1");

                entity.Property(e => e.EffectValue2).HasColumnName("effect_value_2");

                entity.Property(e => e.EnableRequest).HasColumnName("enable_request");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnName("end_date");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.ItemCategory).HasColumnName("item_category");

                entity.Property(e => e.ItemPlaceId).HasColumnName("item_place_id");

                entity.Property(e => e.LimitNum).HasColumnName("limit_num");

                entity.Property(e => e.Rare).HasColumnName("rare");

                entity.Property(e => e.RequestReward).HasColumnName("request_reward");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<ItemExchange>(entity =>
            {
                entity.ToTable("item_exchange");

                entity.HasIndex(e => e.ItemExchangeTopId, "item_exchange_0_item_exchange_top_id");

                entity.HasIndex(e => e.PayItemId, "item_exchange_0_pay_item_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AdditionalPieceNum).HasColumnName("additional_piece_num");

                entity.Property(e => e.ChangeItemCategory).HasColumnName("change_item_category");

                entity.Property(e => e.ChangeItemId).HasColumnName("change_item_id");

                entity.Property(e => e.ChangeItemLimitNum).HasColumnName("change_item_limit_num");

                entity.Property(e => e.ChangeItemLimitType).HasColumnName("change_item_limit_type");

                entity.Property(e => e.ChangeItemNum).HasColumnName("change_item_num");

                entity.Property(e => e.ConditionType).HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.ItemExchangeTopId).HasColumnName("item_exchange_top_id");

                entity.Property(e => e.PayItemCategory).HasColumnName("pay_item_category");

                entity.Property(e => e.PayItemId).HasColumnName("pay_item_id");

                entity.Property(e => e.PayItemNum).HasColumnName("pay_item_num");

                entity.Property(e => e.PriceChangeGroupId).HasColumnName("price_change_group_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");
            });

            modelBuilder.Entity<ItemExchangeTop>(entity =>
            {
                entity.ToTable("item_exchange_top");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ItemExchangeDispOrder).HasColumnName("item_exchange_disp_order");
            });

            modelBuilder.Entity<ItemGroup>(entity =>
            {
                entity.ToTable("item_group");

                entity.HasIndex(e => e.GroupId, "item_group_0_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");
            });

            modelBuilder.Entity<ItemPack>(entity =>
            {
                entity.ToTable("item_pack");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnName("end_date");

                entity.Property(e => e.ItemCategory).HasColumnName("item_category");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemNum).HasColumnName("item_num");

                entity.Property(e => e.ItemPackId).HasColumnName("item_pack_id");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<ItemPlace>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("item_place");

                entity.HasIndex(e => new { e.Id, e.TransitionType, e.TransitionValue }, "IX_item_place_id_transition_type_transition_value")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "item_place_0_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TransitionType).HasColumnName("transition_type");

                entity.Property(e => e.TransitionValue).HasColumnName("transition_value");
            });

            modelBuilder.Entity<LegendRace>(entity =>
            {
                entity.ToTable("legend_race");

                entity.HasIndex(e => e.GroupId, "legend_race_0_group_id");

                entity.HasIndex(e => e.RaceInstanceId, "legend_race_0_race_instance_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CostNum).HasColumnName("cost_num");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.DropRewardOddsId).HasColumnName("drop_reward_odds_id");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.FirstClearItemCategory1).HasColumnName("first_clear_item_category_1");

                entity.Property(e => e.FirstClearItemCategory2).HasColumnName("first_clear_item_category_2");

                entity.Property(e => e.FirstClearItemCategory3).HasColumnName("first_clear_item_category_3");

                entity.Property(e => e.FirstClearItemId1).HasColumnName("first_clear_item_id_1");

                entity.Property(e => e.FirstClearItemId2).HasColumnName("first_clear_item_id_2");

                entity.Property(e => e.FirstClearItemId3).HasColumnName("first_clear_item_id_3");

                entity.Property(e => e.FirstClearItemNum1).HasColumnName("first_clear_item_num_1");

                entity.Property(e => e.FirstClearItemNum2).HasColumnName("first_clear_item_num_2");

                entity.Property(e => e.FirstClearItemNum3).HasColumnName("first_clear_item_num_3");

                entity.Property(e => e.Ground).HasColumnName("ground");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.ImageId).HasColumnName("image_id");

                entity.Property(e => e.LegendBgId).HasColumnName("legend_bg_id");

                entity.Property(e => e.LegendBgSubId).HasColumnName("legend_bg_sub_id");

                entity.Property(e => e.LegendRaceBossNpcId).HasColumnName("legend_race_boss_npc_id");

                entity.Property(e => e.PickUpItemCategory1).HasColumnName("pick_up_item_category_1");

                entity.Property(e => e.PickUpItemCategory2).HasColumnName("pick_up_item_category_2");

                entity.Property(e => e.PickUpItemCategory3).HasColumnName("pick_up_item_category_3");

                entity.Property(e => e.PickUpItemId1).HasColumnName("pick_up_item_id_1");

                entity.Property(e => e.PickUpItemId2).HasColumnName("pick_up_item_id_2");

                entity.Property(e => e.PickUpItemId3).HasColumnName("pick_up_item_id_3");

                entity.Property(e => e.PickUpItemNum1).HasColumnName("pick_up_item_num_1");

                entity.Property(e => e.PickUpItemNum2).HasColumnName("pick_up_item_num_2");

                entity.Property(e => e.PickUpItemNum3).HasColumnName("pick_up_item_num_3");

                entity.Property(e => e.RaceInstanceId).HasColumnName("race_instance_id");

                entity.Property(e => e.Season).HasColumnName("season");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.VictoryRewardOddsId).HasColumnName("victory_reward_odds_id");

                entity.Property(e => e.Weather).HasColumnName("weather");
            });

            modelBuilder.Entity<LegendRaceBilling>(entity =>
            {
                entity.ToTable("legend_race_billing");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Frequency).HasColumnName("frequency");

                entity.Property(e => e.PayCost).HasColumnName("pay_cost");
            });

            modelBuilder.Entity<LegendRaceBossNpc>(entity =>
            {
                entity.ToTable("legend_race_boss_npc");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CardRarityDataId).HasColumnName("card_rarity_data_id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.Guts).HasColumnName("guts");

                entity.Property(e => e.NicknameId).HasColumnName("nickname_id");

                entity.Property(e => e.Pow).HasColumnName("pow");

                entity.Property(e => e.ProperDistanceLong).HasColumnName("proper_distance_long");

                entity.Property(e => e.ProperDistanceMiddle).HasColumnName("proper_distance_middle");

                entity.Property(e => e.ProperDistanceMile).HasColumnName("proper_distance_mile");

                entity.Property(e => e.ProperDistanceShort).HasColumnName("proper_distance_short");

                entity.Property(e => e.ProperGroundDirt).HasColumnName("proper_ground_dirt");

                entity.Property(e => e.ProperGroundTurf).HasColumnName("proper_ground_turf");

                entity.Property(e => e.ProperRunningStyleNige).HasColumnName("proper_running_style_nige");

                entity.Property(e => e.ProperRunningStyleOikomi).HasColumnName("proper_running_style_oikomi");

                entity.Property(e => e.ProperRunningStyleSashi).HasColumnName("proper_running_style_sashi");

                entity.Property(e => e.ProperRunningStyleSenko).HasColumnName("proper_running_style_senko");

                entity.Property(e => e.RaceDressId).HasColumnName("race_dress_id");

                entity.Property(e => e.SkillSetId).HasColumnName("skill_set_id");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.Stamina).HasColumnName("stamina");

                entity.Property(e => e.Wiz).HasColumnName("wiz");
            });

            modelBuilder.Entity<LegendRaceNpc>(entity =>
            {
                entity.ToTable("legend_race_npc");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.Guts).HasColumnName("guts");

                entity.Property(e => e.MobId).HasColumnName("mob_id");

                entity.Property(e => e.NpcGroupId).HasColumnName("npc_group_id");

                entity.Property(e => e.Pow).HasColumnName("pow");

                entity.Property(e => e.ProperDistanceLong).HasColumnName("proper_distance_long");

                entity.Property(e => e.ProperDistanceMiddle).HasColumnName("proper_distance_middle");

                entity.Property(e => e.ProperDistanceMile).HasColumnName("proper_distance_mile");

                entity.Property(e => e.ProperDistanceShort).HasColumnName("proper_distance_short");

                entity.Property(e => e.ProperGroundDirt).HasColumnName("proper_ground_dirt");

                entity.Property(e => e.ProperGroundTurf).HasColumnName("proper_ground_turf");

                entity.Property(e => e.ProperRunningStyleNige).HasColumnName("proper_running_style_nige");

                entity.Property(e => e.ProperRunningStyleOikomi).HasColumnName("proper_running_style_oikomi");

                entity.Property(e => e.ProperRunningStyleSashi).HasColumnName("proper_running_style_sashi");

                entity.Property(e => e.ProperRunningStyleSenko).HasColumnName("proper_running_style_senko");

                entity.Property(e => e.RaceDressId).HasColumnName("race_dress_id");

                entity.Property(e => e.RaceInstanceId).HasColumnName("race_instance_id");

                entity.Property(e => e.SkillSetId).HasColumnName("skill_set_id");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.Stamina).HasColumnName("stamina");

                entity.Property(e => e.Wiz).HasColumnName("wiz");
            });

            modelBuilder.Entity<LimitedExchange>(entity =>
            {
                entity.ToTable("limited_exchange");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DailyRaceCeiling).HasColumnName("daily_race_ceiling");

                entity.Property(e => e.DailyRaceOdds).HasColumnName("daily_race_odds");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.ItemExchangeTopId).HasColumnName("item_exchange_top_id");

                entity.Property(e => e.ItemLineupValue).HasColumnName("item_lineup_value");

                entity.Property(e => e.LegendRaceCeiling).HasColumnName("legend_race_ceiling");

                entity.Property(e => e.LegendRaceOdds).HasColumnName("legend_race_odds");

                entity.Property(e => e.OddsId).HasColumnName("odds_id");

                entity.Property(e => e.OpenValue).HasColumnName("open_value");

                entity.Property(e => e.SingleModeCeiling).HasColumnName("single_mode_ceiling");

                entity.Property(e => e.SingleModeOdds).HasColumnName("single_mode_odds");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.TeamStadiumCeiling).HasColumnName("team_stadium_ceiling");

                entity.Property(e => e.TeamStadiumOdds).HasColumnName("team_stadium_odds");
            });

            modelBuilder.Entity<LimitedExchangeReward>(entity =>
            {
                entity.ToTable("limited_exchange_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.ItemExchangeId).HasColumnName("item_exchange_id");

                entity.Property(e => e.Odds).HasColumnName("odds");

                entity.Property(e => e.RibbonValue).HasColumnName("ribbon_value");
            });

            modelBuilder.Entity<LimitedExchangeRewardOdd>(entity =>
            {
                entity.ToTable("limited_exchange_reward_odds");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.Odds).HasColumnName("odds");

                entity.Property(e => e.OddsId).HasColumnName("odds_id");
            });

            modelBuilder.Entity<LiveDatum>(entity =>
            {
                entity.HasKey(e => e.MusicId);

                entity.ToTable("live_data");

                entity.HasIndex(e => e.Sort, "IX_live_data_sort")
                    .IsUnique();

                entity.Property(e => e.MusicId)
                    .ValueGeneratedNever()
                    .HasColumnName("music_id");

                entity.Property(e => e.BackdancerDress).HasColumnName("backdancer_dress");

                entity.Property(e => e.BackdancerDressColor).HasColumnName("backdancer_dress_color");

                entity.Property(e => e.BackdancerOrder).HasColumnName("backdancer_order");

                entity.Property(e => e.ConditionType).HasColumnName("condition_type");

                entity.Property(e => e.DefaultMainDress).HasColumnName("default_main_dress");

                entity.Property(e => e.DefaultMainDressColor).HasColumnName("default_main_dress_color");

                entity.Property(e => e.DefaultMobDress).HasColumnName("default_mob_dress");

                entity.Property(e => e.DefaultMobDressColor).HasColumnName("default_mob_dress_color");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.LiveMemberNumber).HasColumnName("live_member_number");

                entity.Property(e => e.MusicType).HasColumnName("music_type");

                entity.Property(e => e.SongCharaType).HasColumnName("song_chara_type");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.TitleColorBottom)
                    .IsRequired()
                    .HasColumnName("title_color_bottom");

                entity.Property(e => e.TitleColorTop)
                    .IsRequired()
                    .HasColumnName("title_color_top");
            });

            modelBuilder.Entity<LivePermissionDatum>(entity =>
            {
                entity.HasKey(e => new { e.MusicId, e.CharaId });

                entity.ToTable("live_permission_data");

                entity.HasIndex(e => e.MusicId, "live_permission_data_0_music_id");

                entity.Property(e => e.MusicId).HasColumnName("music_id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");
            });

            modelBuilder.Entity<LoginBonusDatum>(entity =>
            {
                entity.ToTable("login_bonus_data");

                entity.HasIndex(e => e.DispOrder, "IX_login_bonus_data_disp_order")
                    .IsUnique();

                entity.HasIndex(e => e.Type, "login_bonus_data_0_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CountNum).HasColumnName("count_num");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnName("end_date");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("start_date");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<LoginBonusDetail>(entity =>
            {
                entity.ToTable("login_bonus_detail");

                entity.HasIndex(e => new { e.LoginBonusId, e.Count }, "IX_login_bonus_detail_login_bonus_id_count")
                    .IsUnique();

                entity.HasIndex(e => e.LoginBonusId, "login_bonus_detail_0_login_bonus_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.ItemCategory).HasColumnName("item_category");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemNum).HasColumnName("item_num");

                entity.Property(e => e.LoginBonusId).HasColumnName("login_bonus_id");
            });

            modelBuilder.Entity<LoveRank>(entity =>
            {
                entity.ToTable("love_rank");

                entity.HasIndex(e => e.Rank, "love_rank_0_rank")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Rank).HasColumnName("rank");

                entity.Property(e => e.TotalPoint).HasColumnName("total_point");
            });

            modelBuilder.Entity<MainStoryDatum>(entity =>
            {
                entity.ToTable("main_story_data");

                entity.HasIndex(e => e.PartId, "main_story_data_0_part_id");

                entity.HasIndex(e => e.StoryId1, "main_story_data_0_story_id_1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AddRewardCategory1).HasColumnName("add_reward_category_1");

                entity.Property(e => e.AddRewardId1).HasColumnName("add_reward_id_1");

                entity.Property(e => e.AddRewardNum1).HasColumnName("add_reward_num_1");

                entity.Property(e => e.EpisodeIndex).HasColumnName("episode_index");

                entity.Property(e => e.LockType1).HasColumnName("lock_type_1");

                entity.Property(e => e.LockType2).HasColumnName("lock_type_2");

                entity.Property(e => e.LockType3).HasColumnName("lock_type_3");

                entity.Property(e => e.LockValue11).HasColumnName("lock_value_1_1");

                entity.Property(e => e.LockValue12).HasColumnName("lock_value_1_2");

                entity.Property(e => e.LockValue21).HasColumnName("lock_value_2_1");

                entity.Property(e => e.LockValue22).HasColumnName("lock_value_2_2");

                entity.Property(e => e.LockValue31).HasColumnName("lock_value_3_1");

                entity.Property(e => e.LockValue32).HasColumnName("lock_value_3_2");

                entity.Property(e => e.PartId).HasColumnName("part_id");

                entity.Property(e => e.StoryId1).HasColumnName("story_id_1");

                entity.Property(e => e.StoryId2).HasColumnName("story_id_2");

                entity.Property(e => e.StoryId3).HasColumnName("story_id_3");

                entity.Property(e => e.StoryId4).HasColumnName("story_id_4");

                entity.Property(e => e.StoryId5).HasColumnName("story_id_5");

                entity.Property(e => e.StoryNumber).HasColumnName("story_number");

                entity.Property(e => e.StoryType1).HasColumnName("story_type_1");

                entity.Property(e => e.StoryType2).HasColumnName("story_type_2");

                entity.Property(e => e.StoryType3).HasColumnName("story_type_3");

                entity.Property(e => e.StoryType4).HasColumnName("story_type_4");

                entity.Property(e => e.StoryType5).HasColumnName("story_type_5");
            });

            modelBuilder.Entity<MainStoryPart>(entity =>
            {
                entity.ToTable("main_story_part");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MainStoryLastChapter).HasColumnName("main_story_last_chapter");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.UiColor)
                    .IsRequired()
                    .HasColumnName("ui_color");
            });

            modelBuilder.Entity<MainStoryRaceCharaDatum>(entity =>
            {
                entity.ToTable("main_story_race_chara_data");

                entity.HasIndex(e => e.GroupId, "main_story_race_chara_data_0_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BracketNumber).HasColumnName("bracket_number");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.DressId).HasColumnName("dress_id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.Guts).HasColumnName("guts");

                entity.Property(e => e.MobId).HasColumnName("mob_id");

                entity.Property(e => e.Motivation).HasColumnName("motivation");

                entity.Property(e => e.Pow).HasColumnName("pow");

                entity.Property(e => e.ProperDistanceLong).HasColumnName("proper_distance_long");

                entity.Property(e => e.ProperDistanceMiddle).HasColumnName("proper_distance_middle");

                entity.Property(e => e.ProperDistanceMile).HasColumnName("proper_distance_mile");

                entity.Property(e => e.ProperDistanceShort).HasColumnName("proper_distance_short");

                entity.Property(e => e.ProperGroundDirt).HasColumnName("proper_ground_dirt");

                entity.Property(e => e.ProperGroundTurf).HasColumnName("proper_ground_turf");

                entity.Property(e => e.ProperRunningStyleNige).HasColumnName("proper_running_style_nige");

                entity.Property(e => e.ProperRunningStyleOikomi).HasColumnName("proper_running_style_oikomi");

                entity.Property(e => e.ProperRunningStyleSashi).HasColumnName("proper_running_style_sashi");

                entity.Property(e => e.ProperRunningStyleSenko).HasColumnName("proper_running_style_senko");

                entity.Property(e => e.RunningStyle).HasColumnName("running_style");

                entity.Property(e => e.SkillSetId).HasColumnName("skill_set_id");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.Stamina).HasColumnName("stamina");

                entity.Property(e => e.Wiz).HasColumnName("wiz");
            });

            modelBuilder.Entity<MainStoryRaceDatum>(entity =>
            {
                entity.ToTable("main_story_race_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BonusChara1).HasColumnName("bonus_chara_1");

                entity.Property(e => e.BonusChara2).HasColumnName("bonus_chara_2");

                entity.Property(e => e.BonusChara3).HasColumnName("bonus_chara_3");

                entity.Property(e => e.ClearRank).HasColumnName("clear_rank");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.RaceConditionId).HasColumnName("race_condition_id");

                entity.Property(e => e.RaceInstanceId).HasColumnName("race_instance_id");
            });

            modelBuilder.Entity<MiniBg>(entity =>
            {
                entity.ToTable("mini_bg");

                entity.HasIndex(e => e.SceneType, "mini_bg_0_scene_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DressId).HasColumnName("dress_id");

                entity.Property(e => e.GridOffsetX)
                    .IsRequired()
                    .HasColumnName("grid_offset_x");

                entity.Property(e => e.GridOffsetY)
                    .IsRequired()
                    .HasColumnName("grid_offset_y");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasColumnName("position");

                entity.Property(e => e.ReleaseNum).HasColumnName("release_num");

                entity.Property(e => e.SceneType).HasColumnName("scene_type");

                entity.Property(e => e.SizeX).HasColumnName("size_x");

                entity.Property(e => e.SizeY).HasColumnName("size_y");
            });

            modelBuilder.Entity<MiniBgCharaMotion>(entity =>
            {
                entity.ToTable("mini_bg_chara_motion");

                entity.HasIndex(e => e.BgId, "mini_bg_chara_motion_0_bg_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BgId).HasColumnName("bg_id");

                entity.Property(e => e.CharaPosY)
                    .IsRequired()
                    .HasColumnName("chara_pos_y");

                entity.Property(e => e.CharaShadow).HasColumnName("chara_shadow");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.EffectId).HasColumnName("effect_id");

                entity.Property(e => e.EffectStartSec)
                    .IsRequired()
                    .HasColumnName("effect_start_sec");

                entity.Property(e => e.FixedRenderOrder).HasColumnName("fixed_render_order");

                entity.Property(e => e.GridPosX).HasColumnName("grid_pos_x");

                entity.Property(e => e.GridPosY).HasColumnName("grid_pos_y");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.IsMob).HasColumnName("is_mob");

                entity.Property(e => e.MainCharaNum).HasColumnName("main_chara_num");

                entity.Property(e => e.MotionName)
                    .IsRequired()
                    .HasColumnName("motion_name");

                entity.Property(e => e.PosObj)
                    .IsRequired()
                    .HasColumnName("pos_obj");

                entity.Property(e => e.PositionAnim)
                    .IsRequired()
                    .HasColumnName("position_anim");

                entity.Property(e => e.PositionFile)
                    .IsRequired()
                    .HasColumnName("position_file");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.SeCueName01)
                    .IsRequired()
                    .HasColumnName("se_cue_name01");

                entity.Property(e => e.SeCueName02)
                    .IsRequired()
                    .HasColumnName("se_cue_name02");

                entity.Property(e => e.SeCueSheet01)
                    .IsRequired()
                    .HasColumnName("se_cue_sheet01");

                entity.Property(e => e.SeCueSheet02)
                    .IsRequired()
                    .HasColumnName("se_cue_sheet02");

                entity.Property(e => e.SeStartFrame01).HasColumnName("se_start_frame01");

                entity.Property(e => e.SeStartFrame02).HasColumnName("se_start_frame02");

                entity.Property(e => e.SubGroupId).HasColumnName("sub_group_id");

                entity.Property(e => e.Timeline)
                    .IsRequired()
                    .HasColumnName("timeline");

                entity.Property(e => e.TimelineActor)
                    .IsRequired()
                    .HasColumnName("timeline_actor");

                entity.Property(e => e.UseGridPosJobSelect).HasColumnName("use_grid_pos_job_select");
            });

            modelBuilder.Entity<MiniFaceTypeDatum>(entity =>
            {
                entity.HasKey(e => e.Label);

                entity.ToTable("mini_face_type_data");

                entity.Property(e => e.Label).HasColumnName("label");

                entity.Property(e => e.Cheek).HasColumnName("cheek");

                entity.Property(e => e.EyeL).HasColumnName("eye_l");

                entity.Property(e => e.EyeR).HasColumnName("eye_r");

                entity.Property(e => e.EyebrowL).HasColumnName("eyebrow_l");

                entity.Property(e => e.EyebrowR).HasColumnName("eyebrow_r");

                entity.Property(e => e.Mouth).HasColumnName("mouth");
            });

            modelBuilder.Entity<MiniMotionSet>(entity =>
            {
                entity.HasKey(e => e.Label);

                entity.ToTable("mini_motion_set");

                entity.HasIndex(e => e.Id, "mini_motion_set_0_id");

                entity.Property(e => e.Label).HasColumnName("label");

                entity.Property(e => e.AddLayerIndex).HasColumnName("add_layer_index");

                entity.Property(e => e.BodyMotion)
                    .IsRequired()
                    .HasColumnName("body_motion");

                entity.Property(e => e.BodyMotionPlayType).HasColumnName("body_motion_play_type");

                entity.Property(e => e.BodyMotionSceneType).HasColumnName("body_motion_scene_type");

                entity.Property(e => e.BodyMotionType).HasColumnName("body_motion_type");

                entity.Property(e => e.CharaFaceType)
                    .IsRequired()
                    .HasColumnName("chara_face_type");

                entity.Property(e => e.CharaTypeTarget).HasColumnName("chara_type_target");

                entity.Property(e => e.EarMotion)
                    .IsRequired()
                    .HasColumnName("ear_motion");

                entity.Property(e => e.FacialMotion)
                    .IsRequired()
                    .HasColumnName("facial_motion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsEnableRandomeEar).HasColumnName("is_enable_randome_ear");

                entity.Property(e => e.IsEnableRandomeTail).HasColumnName("is_enable_randome_tail");

                entity.Property(e => e.IsMirror).HasColumnName("is_mirror");

                entity.Property(e => e.IsPropRequireMotionEnd).HasColumnName("is_prop_require_motion_end");

                entity.Property(e => e.PropAttachNodeNameType).HasColumnName("prop_attach_node_name_type");

                entity.Property(e => e.PropId).HasColumnName("prop_id");

                entity.Property(e => e.PropMotion)
                    .IsRequired()
                    .HasColumnName("prop_motion");

                entity.Property(e => e.PropMotionSceneType).HasColumnName("prop_motion_scene_type");

                entity.Property(e => e.SceneSubFolder)
                    .IsRequired()
                    .HasColumnName("scene_sub_folder");

                entity.Property(e => e.TailMotion)
                    .IsRequired()
                    .HasColumnName("tail_motion");

                entity.Property(e => e.TailMotionType).HasColumnName("tail_motion_type");

                entity.Property(e => e.TransitionTime).HasColumnName("transition_time");
            });

            modelBuilder.Entity<MiniMouthType>(entity =>
            {
                entity.ToTable("mini_mouth_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ReverseMouthId).HasColumnName("reverse_mouth_id");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<MissionDatum>(entity =>
            {
                entity.ToTable("mission_data");

                entity.HasIndex(e => e.MissionType, "mission_data_0_mission_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionType).HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.ConditionValue4).HasColumnName("condition_value_4");

                entity.Property(e => e.DateCheckFlg).HasColumnName("date_check_flg");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnName("end_date");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.ItemCategory).HasColumnName("item_category");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemNum).HasColumnName("item_num");

                entity.Property(e => e.MissionType).HasColumnName("mission_type");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("start_date");

                entity.Property(e => e.StepGroupId).HasColumnName("step_group_id");

                entity.Property(e => e.StepOrder).HasColumnName("step_order");

                entity.Property(e => e.TransitionType).HasColumnName("transition_type");
            });

            modelBuilder.Entity<MobDatum>(entity =>
            {
                entity.HasKey(e => e.MobId);

                entity.ToTable("mob_data");

                entity.Property(e => e.MobId)
                    .ValueGeneratedNever()
                    .HasColumnName("mob_id");

                entity.Property(e => e.AttachmentModelId).HasColumnName("attachment_model_id");

                entity.Property(e => e.CaptureType).HasColumnName("capture_type");

                entity.Property(e => e.CharaBustSize).HasColumnName("chara_bust_size");

                entity.Property(e => e.CharaFaceModel).HasColumnName("chara_face_model");

                entity.Property(e => e.CharaHairColor).HasColumnName("chara_hair_color");

                entity.Property(e => e.CharaHairModel).HasColumnName("chara_hair_model");

                entity.Property(e => e.CharaHeight).HasColumnName("chara_height");

                entity.Property(e => e.CharaSkinColor).HasColumnName("chara_skin_color");

                entity.Property(e => e.DefaultPersonality).HasColumnName("default_personality");

                entity.Property(e => e.DressColorId).HasColumnName("dress_color_id");

                entity.Property(e => e.DressId).HasColumnName("dress_id");

                entity.Property(e => e.HairCutoff).HasColumnName("hair_cutoff");

                entity.Property(e => e.RacePersonality).HasColumnName("race_personality");

                entity.Property(e => e.RaceRunningType).HasColumnName("race_running_type");

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.Property(e => e.Socks).HasColumnName("socks");

                entity.Property(e => e.UseLive).HasColumnName("use_live");
            });

            modelBuilder.Entity<MobDressColorSet>(entity =>
            {
                entity.ToTable("mob_dress_color_set");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ColorB1)
                    .IsRequired()
                    .HasColumnName("color_b1");

                entity.Property(e => e.ColorB2)
                    .IsRequired()
                    .HasColumnName("color_b2");

                entity.Property(e => e.ColorG1)
                    .IsRequired()
                    .HasColumnName("color_g1");

                entity.Property(e => e.ColorG2)
                    .IsRequired()
                    .HasColumnName("color_g2");

                entity.Property(e => e.ColorR1)
                    .IsRequired()
                    .HasColumnName("color_r1");

                entity.Property(e => e.ColorR2)
                    .IsRequired()
                    .HasColumnName("color_r2");

                entity.Property(e => e.ToonColorB1)
                    .IsRequired()
                    .HasColumnName("toon_color_b1");

                entity.Property(e => e.ToonColorB2)
                    .IsRequired()
                    .HasColumnName("toon_color_b2");

                entity.Property(e => e.ToonColorG1)
                    .IsRequired()
                    .HasColumnName("toon_color_g1");

                entity.Property(e => e.ToonColorG2)
                    .IsRequired()
                    .HasColumnName("toon_color_g2");

                entity.Property(e => e.ToonColorR1)
                    .IsRequired()
                    .HasColumnName("toon_color_r1");

                entity.Property(e => e.ToonColorR2)
                    .IsRequired()
                    .HasColumnName("toon_color_r2");
            });

            modelBuilder.Entity<MobHairColorSet>(entity =>
            {
                entity.ToTable("mob_hair_color_set");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EyeColorB1)
                    .IsRequired()
                    .HasColumnName("eye_color_b1");

                entity.Property(e => e.EyeColorB2)
                    .IsRequired()
                    .HasColumnName("eye_color_b2");

                entity.Property(e => e.EyeColorG1)
                    .IsRequired()
                    .HasColumnName("eye_color_g1");

                entity.Property(e => e.EyeColorG2)
                    .IsRequired()
                    .HasColumnName("eye_color_g2");

                entity.Property(e => e.EyeColorR1)
                    .IsRequired()
                    .HasColumnName("eye_color_r1");

                entity.Property(e => e.EyeColorR2)
                    .IsRequired()
                    .HasColumnName("eye_color_r2");

                entity.Property(e => e.HairColorB1)
                    .IsRequired()
                    .HasColumnName("hair_color_b1");

                entity.Property(e => e.HairColorB2)
                    .IsRequired()
                    .HasColumnName("hair_color_b2");

                entity.Property(e => e.HairColorG1)
                    .IsRequired()
                    .HasColumnName("hair_color_g1");

                entity.Property(e => e.HairColorG2)
                    .IsRequired()
                    .HasColumnName("hair_color_g2");

                entity.Property(e => e.HairColorR1)
                    .IsRequired()
                    .HasColumnName("hair_color_r1");

                entity.Property(e => e.HairColorR2)
                    .IsRequired()
                    .HasColumnName("hair_color_r2");

                entity.Property(e => e.HairToonColorB1)
                    .IsRequired()
                    .HasColumnName("hair_toon_color_b1");

                entity.Property(e => e.HairToonColorB2)
                    .IsRequired()
                    .HasColumnName("hair_toon_color_b2");

                entity.Property(e => e.HairToonColorG1)
                    .IsRequired()
                    .HasColumnName("hair_toon_color_g1");

                entity.Property(e => e.HairToonColorG2)
                    .IsRequired()
                    .HasColumnName("hair_toon_color_g2");

                entity.Property(e => e.HairToonColorR1)
                    .IsRequired()
                    .HasColumnName("hair_toon_color_r1");

                entity.Property(e => e.HairToonColorR2)
                    .IsRequired()
                    .HasColumnName("hair_toon_color_r2");

                entity.Property(e => e.MayuColorB1)
                    .IsRequired()
                    .HasColumnName("mayu_color_b1");

                entity.Property(e => e.MayuColorB2)
                    .IsRequired()
                    .HasColumnName("mayu_color_b2");

                entity.Property(e => e.MayuColorG1)
                    .IsRequired()
                    .HasColumnName("mayu_color_g1");

                entity.Property(e => e.MayuColorG2)
                    .IsRequired()
                    .HasColumnName("mayu_color_g2");

                entity.Property(e => e.MayuColorR1)
                    .IsRequired()
                    .HasColumnName("mayu_color_r1");

                entity.Property(e => e.MayuColorR2)
                    .IsRequired()
                    .HasColumnName("mayu_color_r2");

                entity.Property(e => e.MayuToonColorB1)
                    .IsRequired()
                    .HasColumnName("mayu_toon_color_b1");

                entity.Property(e => e.MayuToonColorB2)
                    .IsRequired()
                    .HasColumnName("mayu_toon_color_b2");

                entity.Property(e => e.MayuToonColorG1)
                    .IsRequired()
                    .HasColumnName("mayu_toon_color_g1");

                entity.Property(e => e.MayuToonColorG2)
                    .IsRequired()
                    .HasColumnName("mayu_toon_color_g2");

                entity.Property(e => e.MayuToonColorR1)
                    .IsRequired()
                    .HasColumnName("mayu_toon_color_r1");

                entity.Property(e => e.MayuToonColorR2)
                    .IsRequired()
                    .HasColumnName("mayu_toon_color_r2");

                entity.Property(e => e.TailColorB1)
                    .IsRequired()
                    .HasColumnName("tail_color_b1");

                entity.Property(e => e.TailColorB2)
                    .IsRequired()
                    .HasColumnName("tail_color_b2");

                entity.Property(e => e.TailColorG1)
                    .IsRequired()
                    .HasColumnName("tail_color_g1");

                entity.Property(e => e.TailColorG2)
                    .IsRequired()
                    .HasColumnName("tail_color_g2");

                entity.Property(e => e.TailColorR1)
                    .IsRequired()
                    .HasColumnName("tail_color_r1");

                entity.Property(e => e.TailColorR2)
                    .IsRequired()
                    .HasColumnName("tail_color_r2");

                entity.Property(e => e.TailToonColorB1)
                    .IsRequired()
                    .HasColumnName("tail_toon_color_b1");

                entity.Property(e => e.TailToonColorB2)
                    .IsRequired()
                    .HasColumnName("tail_toon_color_b2");

                entity.Property(e => e.TailToonColorG1)
                    .IsRequired()
                    .HasColumnName("tail_toon_color_g1");

                entity.Property(e => e.TailToonColorG2)
                    .IsRequired()
                    .HasColumnName("tail_toon_color_g2");

                entity.Property(e => e.TailToonColorR1)
                    .IsRequired()
                    .HasColumnName("tail_toon_color_r1");

                entity.Property(e => e.TailToonColorR2)
                    .IsRequired()
                    .HasColumnName("tail_toon_color_r2");
            });

            modelBuilder.Entity<NeedPieceNumDatum>(entity =>
            {
                entity.ToTable("need_piece_num_data");

                entity.HasIndex(e => e.Rarity, "need_piece_num_data_0_rarity")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.PieceNum).HasColumnName("piece_num");

                entity.Property(e => e.Rarity).HasColumnName("rarity");
            });

            modelBuilder.Entity<Nickname>(entity =>
            {
                entity.ToTable("nickname");

                entity.HasIndex(e => e.UserShow, "nickname_0_user_show");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaDataId).HasColumnName("chara_data_id");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.Rank).HasColumnName("rank");

                entity.Property(e => e.ReceiveConditionType).HasColumnName("receive_condition_type");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.UserShow).HasColumnName("user_show");
            });

            modelBuilder.Entity<NoteProfile>(entity =>
            {
                entity.ToTable("note_profile");

                entity.HasIndex(e => e.CharaId, "note_profile_0_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.LockType).HasColumnName("lock_type");

                entity.Property(e => e.LockValue).HasColumnName("lock_value");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.TextType).HasColumnName("text_type");
            });

            modelBuilder.Entity<NoteProfileTextType>(entity =>
            {
                entity.ToTable("note_profile_text_type");

                entity.HasIndex(e => e.TextType, "note_profile_text_type_0_text_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.TextCategoryId).HasColumnName("text_category_id");

                entity.Property(e => e.TextType).HasColumnName("text_type");
            });

            modelBuilder.Entity<PieceDatum>(entity =>
            {
                entity.ToTable("piece_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnName("end_date");

                entity.Property(e => e.ItemPlaceId).HasColumnName("item_place_id");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<PriceChange>(entity =>
            {
                entity.ToTable("price_change");

                entity.HasIndex(e => e.GroupId, "price_change_0_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.MaxNum).HasColumnName("max_num");

                entity.Property(e => e.MinNum).HasColumnName("min_num");

                entity.Property(e => e.PayItemNum).HasColumnName("pay_item_num");
            });

            modelBuilder.Entity<Race>(entity =>
            {
                entity.ToTable("race");

                entity.HasIndex(e => e.CourseSet, "race_0_course_set");

                entity.HasIndex(e => e.Group, "race_0_group");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CourseSet).HasColumnName("course_set");

                entity.Property(e => e.EntryNum).HasColumnName("entry_num");

                entity.Property(e => e.FfAnim).HasColumnName("ff_anim");

                entity.Property(e => e.FfCamera).HasColumnName("ff_camera");

                entity.Property(e => e.FfCameraSub).HasColumnName("ff_camera_sub");

                entity.Property(e => e.FfCueName)
                    .IsRequired()
                    .HasColumnName("ff_cue_name");

                entity.Property(e => e.FfCuesheetName)
                    .IsRequired()
                    .HasColumnName("ff_cuesheet_name");

                entity.Property(e => e.FfSub).HasColumnName("ff_sub");

                entity.Property(e => e.GoalFlower).HasColumnName("goal_flower");

                entity.Property(e => e.GoalGate).HasColumnName("goal_gate");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.Group).HasColumnName("group");

                entity.Property(e => e.ThumbnailId).HasColumnName("thumbnail_id");
            });

            modelBuilder.Entity<RaceBgm>(entity =>
            {
                entity.ToTable("race_bgm");

                entity.HasIndex(e => e.RaceType, "race_bgm_0_race_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EntrytableBgmCueName)
                    .IsRequired()
                    .HasColumnName("entrytable_bgm_cue_name");

                entity.Property(e => e.EntrytableBgmCuesheetName)
                    .IsRequired()
                    .HasColumnName("entrytable_bgm_cuesheet_name");

                entity.Property(e => e.FirstBgmPattern).HasColumnName("first_bgm_pattern");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.PaddockBgmCueName)
                    .IsRequired()
                    .HasColumnName("paddock_bgm_cue_name");

                entity.Property(e => e.PaddockBgmCuesheetName)
                    .IsRequired()
                    .HasColumnName("paddock_bgm_cuesheet_name");

                entity.Property(e => e.RaceInstanceId).HasColumnName("race_instance_id");

                entity.Property(e => e.RaceType).HasColumnName("race_type");

                entity.Property(e => e.ResultCutinBgmCueName1)
                    .IsRequired()
                    .HasColumnName("result_cutin_bgm_cue_name_1");

                entity.Property(e => e.ResultCutinBgmCueName2)
                    .IsRequired()
                    .HasColumnName("result_cutin_bgm_cue_name_2");

                entity.Property(e => e.ResultCutinBgmCueName3)
                    .IsRequired()
                    .HasColumnName("result_cutin_bgm_cue_name_3");

                entity.Property(e => e.ResultCutinBgmCuesheetName1)
                    .IsRequired()
                    .HasColumnName("result_cutin_bgm_cuesheet_name_1");

                entity.Property(e => e.ResultCutinBgmCuesheetName2)
                    .IsRequired()
                    .HasColumnName("result_cutin_bgm_cuesheet_name_2");

                entity.Property(e => e.ResultCutinBgmCuesheetName3)
                    .IsRequired()
                    .HasColumnName("result_cutin_bgm_cuesheet_name_3");

                entity.Property(e => e.ResultListBgmCueName1)
                    .IsRequired()
                    .HasColumnName("result_list_bgm_cue_name_1");

                entity.Property(e => e.ResultListBgmCueName2)
                    .IsRequired()
                    .HasColumnName("result_list_bgm_cue_name_2");

                entity.Property(e => e.ResultListBgmCueName3)
                    .IsRequired()
                    .HasColumnName("result_list_bgm_cue_name_3");

                entity.Property(e => e.ResultListBgmCuesheetName1)
                    .IsRequired()
                    .HasColumnName("result_list_bgm_cuesheet_name_1");

                entity.Property(e => e.ResultListBgmCuesheetName2)
                    .IsRequired()
                    .HasColumnName("result_list_bgm_cuesheet_name_2");

                entity.Property(e => e.ResultListBgmCuesheetName3)
                    .IsRequired()
                    .HasColumnName("result_list_bgm_cuesheet_name_3");

                entity.Property(e => e.SecondBgmPattern).HasColumnName("second_bgm_pattern");

                entity.Property(e => e.SingleModeProgramId).HasColumnName("single_mode_program_id");

                entity.Property(e => e.SingleModeRouteRaceId).HasColumnName("single_mode_route_race_id");
            });

            modelBuilder.Entity<RaceBgmCutinExtensionTime>(entity =>
            {
                entity.ToTable("race_bgm_cutin_extension_time");

                entity.HasIndex(e => e.CutinCategory, "race_bgm_cutin_extension_time_0_cutin_category");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CardId).HasColumnName("card_id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.CutinCategory).HasColumnName("cutin_category");

                entity.Property(e => e.ExtensionSec).HasColumnName("extension_sec");

                entity.Property(e => e.ExtensionSecLong).HasColumnName("extension_sec_long");
            });

            modelBuilder.Entity<RaceBgmPattern>(entity =>
            {
                entity.ToTable("race_bgm_pattern");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BgmCueName1)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_1");

                entity.Property(e => e.BgmCueName10)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_10");

                entity.Property(e => e.BgmCueName11)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_11");

                entity.Property(e => e.BgmCueName12)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_12");

                entity.Property(e => e.BgmCueName13)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_13");

                entity.Property(e => e.BgmCueName14)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_14");

                entity.Property(e => e.BgmCueName15)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_15");

                entity.Property(e => e.BgmCueName16)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_16");

                entity.Property(e => e.BgmCueName17)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_17");

                entity.Property(e => e.BgmCueName18)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_18");

                entity.Property(e => e.BgmCueName19)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_19");

                entity.Property(e => e.BgmCueName2)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_2");

                entity.Property(e => e.BgmCueName20)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_20");

                entity.Property(e => e.BgmCueName21)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_21");

                entity.Property(e => e.BgmCueName22)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_22");

                entity.Property(e => e.BgmCueName23)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_23");

                entity.Property(e => e.BgmCueName24)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_24");

                entity.Property(e => e.BgmCueName25)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_25");

                entity.Property(e => e.BgmCueName26)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_26");

                entity.Property(e => e.BgmCueName27)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_27");

                entity.Property(e => e.BgmCueName28)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_28");

                entity.Property(e => e.BgmCueName29)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_29");

                entity.Property(e => e.BgmCueName3)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_3");

                entity.Property(e => e.BgmCueName30)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_30");

                entity.Property(e => e.BgmCueName4)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_4");

                entity.Property(e => e.BgmCueName5)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_5");

                entity.Property(e => e.BgmCueName6)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_6");

                entity.Property(e => e.BgmCueName7)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_7");

                entity.Property(e => e.BgmCueName8)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_8");

                entity.Property(e => e.BgmCueName9)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name_9");

                entity.Property(e => e.BgmCuesheetName1)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_1");

                entity.Property(e => e.BgmCuesheetName10)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_10");

                entity.Property(e => e.BgmCuesheetName11)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_11");

                entity.Property(e => e.BgmCuesheetName12)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_12");

                entity.Property(e => e.BgmCuesheetName13)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_13");

                entity.Property(e => e.BgmCuesheetName14)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_14");

                entity.Property(e => e.BgmCuesheetName15)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_15");

                entity.Property(e => e.BgmCuesheetName16)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_16");

                entity.Property(e => e.BgmCuesheetName17)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_17");

                entity.Property(e => e.BgmCuesheetName18)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_18");

                entity.Property(e => e.BgmCuesheetName19)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_19");

                entity.Property(e => e.BgmCuesheetName2)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_2");

                entity.Property(e => e.BgmCuesheetName20)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_20");

                entity.Property(e => e.BgmCuesheetName21)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_21");

                entity.Property(e => e.BgmCuesheetName22)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_22");

                entity.Property(e => e.BgmCuesheetName23)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_23");

                entity.Property(e => e.BgmCuesheetName24)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_24");

                entity.Property(e => e.BgmCuesheetName25)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_25");

                entity.Property(e => e.BgmCuesheetName26)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_26");

                entity.Property(e => e.BgmCuesheetName27)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_27");

                entity.Property(e => e.BgmCuesheetName28)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_28");

                entity.Property(e => e.BgmCuesheetName29)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_29");

                entity.Property(e => e.BgmCuesheetName3)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_3");

                entity.Property(e => e.BgmCuesheetName30)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_30");

                entity.Property(e => e.BgmCuesheetName4)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_4");

                entity.Property(e => e.BgmCuesheetName5)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_5");

                entity.Property(e => e.BgmCuesheetName6)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_6");

                entity.Property(e => e.BgmCuesheetName7)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_7");

                entity.Property(e => e.BgmCuesheetName8)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_8");

                entity.Property(e => e.BgmCuesheetName9)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name_9");

                entity.Property(e => e.BgmTime1).HasColumnName("bgm_time_1");

                entity.Property(e => e.BgmTime10).HasColumnName("bgm_time_10");

                entity.Property(e => e.BgmTime11).HasColumnName("bgm_time_11");

                entity.Property(e => e.BgmTime12).HasColumnName("bgm_time_12");

                entity.Property(e => e.BgmTime13).HasColumnName("bgm_time_13");

                entity.Property(e => e.BgmTime14).HasColumnName("bgm_time_14");

                entity.Property(e => e.BgmTime15).HasColumnName("bgm_time_15");

                entity.Property(e => e.BgmTime16).HasColumnName("bgm_time_16");

                entity.Property(e => e.BgmTime17).HasColumnName("bgm_time_17");

                entity.Property(e => e.BgmTime18).HasColumnName("bgm_time_18");

                entity.Property(e => e.BgmTime19).HasColumnName("bgm_time_19");

                entity.Property(e => e.BgmTime2).HasColumnName("bgm_time_2");

                entity.Property(e => e.BgmTime20).HasColumnName("bgm_time_20");

                entity.Property(e => e.BgmTime21).HasColumnName("bgm_time_21");

                entity.Property(e => e.BgmTime22).HasColumnName("bgm_time_22");

                entity.Property(e => e.BgmTime23).HasColumnName("bgm_time_23");

                entity.Property(e => e.BgmTime24).HasColumnName("bgm_time_24");

                entity.Property(e => e.BgmTime25).HasColumnName("bgm_time_25");

                entity.Property(e => e.BgmTime26).HasColumnName("bgm_time_26");

                entity.Property(e => e.BgmTime27).HasColumnName("bgm_time_27");

                entity.Property(e => e.BgmTime28).HasColumnName("bgm_time_28");

                entity.Property(e => e.BgmTime29).HasColumnName("bgm_time_29");

                entity.Property(e => e.BgmTime3).HasColumnName("bgm_time_3");

                entity.Property(e => e.BgmTime30).HasColumnName("bgm_time_30");

                entity.Property(e => e.BgmTime4).HasColumnName("bgm_time_4");

                entity.Property(e => e.BgmTime5).HasColumnName("bgm_time_5");

                entity.Property(e => e.BgmTime6).HasColumnName("bgm_time_6");

                entity.Property(e => e.BgmTime7).HasColumnName("bgm_time_7");

                entity.Property(e => e.BgmTime8).HasColumnName("bgm_time_8");

                entity.Property(e => e.BgmTime9).HasColumnName("bgm_time_9");
            });

            modelBuilder.Entity<RaceBibColor>(entity =>
            {
                entity.HasKey(e => new { e.Grade, e.RaceId });

                entity.ToTable("race_bib_color");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.RaceId).HasColumnName("race_id");

                entity.Property(e => e.BibColor).HasColumnName("bib_color");

                entity.Property(e => e.FontColor).HasColumnName("font_color");
            });

            modelBuilder.Entity<RaceCondition>(entity =>
            {
                entity.ToTable("race_condition");

                entity.HasIndex(e => new { e.Ground, e.Weather }, "race_condition_0_ground_1_weather");

                entity.HasIndex(e => new { e.Season, e.Ground }, "race_condition_0_season_1_ground");

                entity.HasIndex(e => new { e.Season, e.Weather }, "race_condition_0_season_1_weather");

                entity.HasIndex(e => new { e.Weather, e.Ground }, "race_condition_0_weather_1_ground");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Ground).HasColumnName("ground");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Season).HasColumnName("season");

                entity.Property(e => e.Weather).HasColumnName("weather");
            });

            modelBuilder.Entity<RaceCourseSet>(entity =>
            {
                entity.ToTable("race_course_set");

                entity.HasIndex(e => e.RaceTrackId, "race_course_set_0_race_track_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CourseSetStatusId).HasColumnName("course_set_status_id");

                entity.Property(e => e.Distance).HasColumnName("distance");

                entity.Property(e => e.FenceSet).HasColumnName("fence_set");

                entity.Property(e => e.FinishTimeMax).HasColumnName("finish_time_max");

                entity.Property(e => e.FinishTimeMaxRandomRange).HasColumnName("finish_time_max_random_range");

                entity.Property(e => e.FinishTimeMin).HasColumnName("finish_time_min");

                entity.Property(e => e.FinishTimeMinRandomRange).HasColumnName("finish_time_min_random_range");

                entity.Property(e => e.FloatLaneMax).HasColumnName("float_lane_max");

                entity.Property(e => e.Ground).HasColumnName("ground");

                entity.Property(e => e.Inout).HasColumnName("inout");

                entity.Property(e => e.RaceTrackId).HasColumnName("race_track_id");

                entity.Property(e => e.Turn).HasColumnName("turn");
            });

            modelBuilder.Entity<RaceCourseSetStatus>(entity =>
            {
                entity.HasKey(e => e.CourseSetStatusId);

                entity.ToTable("race_course_set_status");

                entity.Property(e => e.CourseSetStatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("course_set_status_id");

                entity.Property(e => e.TargetStatus1).HasColumnName("target_status_1");

                entity.Property(e => e.TargetStatus2).HasColumnName("target_status_2");
            });

            modelBuilder.Entity<RaceEnvDefine>(entity =>
            {
                entity.ToTable("race_env_define");

                entity.HasIndex(e => e.RaceTrackId, "race_env_define_0_race_track_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.RaceTrackId).HasColumnName("race_track_id");

                entity.Property(e => e.Resource).HasColumnName("resource");

                entity.Property(e => e.Season).HasColumnName("season");

                entity.Property(e => e.Timezone).HasColumnName("timezone");

                entity.Property(e => e.Weather).HasColumnName("weather");
            });

            modelBuilder.Entity<RaceFenceSet>(entity =>
            {
                entity.ToTable("race_fence_set");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Fence1).HasColumnName("fence_1");

                entity.Property(e => e.Fence2).HasColumnName("fence_2");

                entity.Property(e => e.Fence3).HasColumnName("fence_3");

                entity.Property(e => e.Fence4).HasColumnName("fence_4");

                entity.Property(e => e.Fence5).HasColumnName("fence_5");

                entity.Property(e => e.Fence6).HasColumnName("fence_6");

                entity.Property(e => e.Fence7).HasColumnName("fence_7");

                entity.Property(e => e.Fence8).HasColumnName("fence_8");
            });

            modelBuilder.Entity<RaceInstance>(entity =>
            {
                entity.ToTable("race_instance");

                entity.HasIndex(e => e.RaceId, "race_instance_0_race_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.NpcGroupId).HasColumnName("npc_group_id");

                entity.Property(e => e.RaceId).HasColumnName("race_id");

                entity.Property(e => e.RaceNumber).HasColumnName("race_number");

                entity.Property(e => e.Time).HasColumnName("time");
            });

            modelBuilder.Entity<RaceJikkyoBase>(entity =>
            {
                entity.ToTable("race_jikkyo_base");

                entity.HasIndex(e => e.Mode, "race_jikkyo_base_0_mode");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CameraHorse1).HasColumnName("camera_horse1");

                entity.Property(e => e.CameraHorse2).HasColumnName("camera_horse2");

                entity.Property(e => e.CameraId).HasColumnName("camera_id");

                entity.Property(e => e.CommentGroup).HasColumnName("comment_group");

                entity.Property(e => e.DisableReentrySituation).HasColumnName("disable_reentry_situation");

                entity.Property(e => e.DisableReuse).HasColumnName("disable_reuse");

                entity.Property(e => e.Discard).HasColumnName("discard");

                entity.Property(e => e.Immediate).HasColumnName("immediate");

                entity.Property(e => e.MessageGroup).HasColumnName("message_group");

                entity.Property(e => e.Mode).HasColumnName("mode");

                entity.Property(e => e.Per).HasColumnName("per");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Situation).HasColumnName("situation");

                entity.Property(e => e.SituationEnd).HasColumnName("situation_end");

                entity.Property(e => e.SubMode).HasColumnName("sub_mode");

                entity.Property(e => e.SubModeJump).HasColumnName("sub_mode_jump");

                entity.Property(e => e.SubSituation).HasColumnName("sub_situation");

                entity.Property(e => e.Tension).HasColumnName("tension");

                entity.Property(e => e.Trigger0).HasColumnName("trigger0");

                entity.Property(e => e.Trigger1).HasColumnName("trigger1");

                entity.Property(e => e.Trigger2).HasColumnName("trigger2");

                entity.Property(e => e.Trigger3).HasColumnName("trigger3");

                entity.Property(e => e.Trigger4).HasColumnName("trigger4");

                entity.Property(e => e.Trigger5).HasColumnName("trigger5");

                entity.Property(e => e.Trigger6).HasColumnName("trigger6");

                entity.Property(e => e.Trigger7).HasColumnName("trigger7");

                entity.Property(e => e.Trigger8).HasColumnName("trigger8");

                entity.Property(e => e.Trigger9).HasColumnName("trigger9");
            });

            modelBuilder.Entity<RaceJikkyoComment>(entity =>
            {
                entity.ToTable("race_jikkyo_comment");

                entity.HasIndex(e => e.GroupId, "race_jikkyo_comment_0_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message");

                entity.Property(e => e.MessageGroup).HasColumnName("message_group");

                entity.Property(e => e.Per).HasColumnName("per");

                entity.Property(e => e.Voice)
                    .IsRequired()
                    .HasColumnName("voice");
            });

            modelBuilder.Entity<RaceJikkyoCue>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CuesheetType });

                entity.ToTable("race_jikkyo_cue");

                entity.HasIndex(e => e.CuesheetType, "race_jikkyo_cue_0_cuesheet_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CuesheetType).HasColumnName("cuesheet_type");

                entity.Property(e => e.CuesheetId).HasColumnName("cuesheet_id");
            });

            modelBuilder.Entity<RaceJikkyoMessage>(entity =>
            {
                entity.ToTable("race_jikkyo_message");

                entity.HasIndex(e => e.CommentGroup, "race_jikkyo_message_0_comment_group");

                entity.HasIndex(e => e.GroupId, "race_jikkyo_message_0_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CommentGroup).HasColumnName("comment_group");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message");

                entity.Property(e => e.Per).HasColumnName("per");

                entity.Property(e => e.Reuse).HasColumnName("reuse");

                entity.Property(e => e.Voice)
                    .IsRequired()
                    .HasColumnName("voice");
            });

            modelBuilder.Entity<RaceJikkyoRace>(entity =>
            {
                entity.ToTable("race_jikkyo_race");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CueId).HasColumnName("cue_id");
            });

            modelBuilder.Entity<RaceJikkyoTrigger>(entity =>
            {
                entity.ToTable("race_jikkyo_trigger");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Command).HasColumnName("command");

                entity.Property(e => e.Horse1).HasColumnName("horse1");

                entity.Property(e => e.Horse2).HasColumnName("horse2");

                entity.Property(e => e.Inequality).HasColumnName("inequality");

                entity.Property(e => e.Param1).HasColumnName("param1");

                entity.Property(e => e.Param2).HasColumnName("param2");
            });

            modelBuilder.Entity<RaceMotivationRate>(entity =>
            {
                entity.ToTable("race_motivation_rate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MotivationRate).HasColumnName("motivation_rate");
            });

            modelBuilder.Entity<RaceOverrunPattern>(entity =>
            {
                entity.ToTable("race_overrun_pattern");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FinishOrder0Type).HasColumnName("finish_order_0_type");

                entity.Property(e => e.FinishOrder1Type).HasColumnName("finish_order_1_type");

                entity.Property(e => e.FinishOrder2Type).HasColumnName("finish_order_2_type");

                entity.Property(e => e.FinishOrder3Type).HasColumnName("finish_order_3_type");

                entity.Property(e => e.FinishOrder4Type).HasColumnName("finish_order_4_type");

                entity.Property(e => e.FinishOrderLoseType).HasColumnName("finish_order_lose_type");
            });

            modelBuilder.Entity<RacePlayerCamera>(entity =>
            {
                entity.ToTable("race_player_camera");

                entity.HasIndex(e => e.Category, "race_player_camera_0_category");

                entity.HasIndex(e => e.PrefabName, "race_player_camera_0_prefab_name");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.PrefabName)
                    .IsRequired()
                    .HasColumnName("prefab_name");

                entity.Property(e => e.Priority).HasColumnName("priority");
            });

            modelBuilder.Entity<RacePopularityProperValue>(entity =>
            {
                entity.ToTable("race_popularity_proper_value");

                entity.HasIndex(e => e.ProperType, "race_popularity_proper_value_0_proper_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ProperGrade).HasColumnName("proper_grade");

                entity.Property(e => e.ProperType).HasColumnName("proper_type");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<RaceProperDistanceRate>(entity =>
            {
                entity.ToTable("race_proper_distance_rate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ProperRatePower).HasColumnName("proper_rate_power");

                entity.Property(e => e.ProperRateSpeed).HasColumnName("proper_rate_speed");
            });

            modelBuilder.Entity<RaceProperGroundRate>(entity =>
            {
                entity.ToTable("race_proper_ground_rate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ProperRate).HasColumnName("proper_rate");
            });

            modelBuilder.Entity<RaceProperRunningstyleRate>(entity =>
            {
                entity.ToTable("race_proper_runningstyle_rate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ProperRate).HasColumnName("proper_rate");
            });

            modelBuilder.Entity<RaceTrack>(entity =>
            {
                entity.ToTable("race_track");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EnableHalfGate).HasColumnName("enable_half_gate");

                entity.Property(e => e.FootsmokeColorType).HasColumnName("footsmoke_color_type");

                entity.Property(e => e.HorseNumGateVariation).HasColumnName("horse_num_gate_variation");

                entity.Property(e => e.InitialLaneType).HasColumnName("initial_lane_type");

                entity.Property(e => e.TurfVisionType).HasColumnName("turf_vision_type");
            });

            modelBuilder.Entity<RaceTrophy>(entity =>
            {
                entity.ToTable("race_trophy");

                entity.HasIndex(e => e.RaceInstanceId, "race_trophy_0_race_instance_id")
                    .IsUnique();

                entity.HasIndex(e => e.TrophyId, "race_trophy_0_trophy_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.DisplayEndDate)
                    .IsRequired()
                    .HasColumnName("display_end_date");

                entity.Property(e => e.EventType).HasColumnName("event_type");

                entity.Property(e => e.OriginalFlag).HasColumnName("original_flag");

                entity.Property(e => e.RaceInstanceId).HasColumnName("race_instance_id");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("start_date");

                entity.Property(e => e.TrophyId).HasColumnName("trophy_id");
            });

            modelBuilder.Entity<RaceTrophyReward>(entity =>
            {
                entity.HasKey(e => e.TrophyId);

                entity.ToTable("race_trophy_reward");

                entity.Property(e => e.TrophyId)
                    .ValueGeneratedNever()
                    .HasColumnName("trophy_id");

                entity.Property(e => e.ItemCategory).HasColumnName("item_category");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemNum).HasColumnName("item_num");
            });

            modelBuilder.Entity<RandomEarTailMotion>(entity =>
            {
                entity.ToTable("random_ear_tail_motion");

                entity.HasIndex(e => e.PartsType, "random_ear_tail_motion_0_parts_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EarType).HasColumnName("ear_type");

                entity.Property(e => e.MotionName)
                    .IsRequired()
                    .HasColumnName("motion_name");

                entity.Property(e => e.PartsType).HasColumnName("parts_type");

                entity.Property(e => e.UseStory).HasColumnName("use_story");
            });

            modelBuilder.Entity<SeasonDatum>(entity =>
            {
                entity.ToTable("season_data");

                entity.HasIndex(e => e.Type, "season_data_0_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnName("end_date");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Season).HasColumnName("season");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("start_date");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<ShortEpisode>(entity =>
            {
                entity.ToTable("short_episode");

                entity.HasIndex(e => e.Scene, "short_episode_0_scene");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConditionType).HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.Scene).HasColumnName("scene");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.StoryId).HasColumnName("story_id");
            });

            modelBuilder.Entity<SingleModeAnalyzeMessage>(entity =>
            {
                entity.ToTable("single_mode_analyze_message");

                entity.HasIndex(e => e.Popularity, "single_mode_analyze_message_0_popularity");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharacterType).HasColumnName("character_type");

                entity.Property(e => e.MotionType).HasColumnName("motion_type");

                entity.Property(e => e.Popularity).HasColumnName("popularity");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.ProperDistance).HasColumnName("proper_distance");

                entity.Property(e => e.ProperGround).HasColumnName("proper_ground");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<SingleModeAnalyzeTicket>(entity =>
            {
                entity.ToTable("single_mode_analyze_ticket");

                entity.HasIndex(e => e.Grade, "single_mode_analyze_ticket_0_grade");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CostTicket).HasColumnName("cost_ticket");

                entity.Property(e => e.Grade).HasColumnName("grade");
            });

            modelBuilder.Entity<SingleModeCharaEffect>(entity =>
            {
                entity.ToTable("single_mode_chara_effect");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EffectCategory).HasColumnName("effect_category");

                entity.Property(e => e.EffectGroupId).HasColumnName("effect_group_id");

                entity.Property(e => e.EffectType).HasColumnName("effect_type");

                entity.Property(e => e.Priority).HasColumnName("priority");
            });

            modelBuilder.Entity<SingleModeCharaGrade>(entity =>
            {
                entity.ToTable("single_mode_chara_grade");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.NeedFanCount).HasColumnName("need_fan_count");

                entity.Property(e => e.RunNum).HasColumnName("run_num");

                entity.Property(e => e.WinNum).HasColumnName("win_num");
            });

            modelBuilder.Entity<SingleModeCharaProgram>(entity =>
            {
                entity.ToTable("single_mode_chara_program");

                entity.HasIndex(e => e.CharaId, "single_mode_chara_program_0_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.ProgramGroup).HasColumnName("program_group");
            });

            modelBuilder.Entity<SingleModeConclusionSet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("single_mode_conclusion_set");

                entity.HasIndex(e => e.StoryId, "single_mode_conclusion_set_0_story_id");

                entity.Property(e => e.ConclusionId).HasColumnName("conclusion_id");

                entity.Property(e => e.RootId).HasColumnName("root_id");

                entity.Property(e => e.StoryId).HasColumnName("story_id");
            });

            modelBuilder.Entity<SingleModeEvaluation>(entity =>
            {
                entity.ToTable("single_mode_evaluation");

                entity.HasIndex(e => e.CharaId, "single_mode_evaluation_0_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.Evaluation).HasColumnName("evaluation");
            });

            modelBuilder.Entity<SingleModeEventConclusion>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CharaId });

                entity.ToTable("single_mode_event_conclusion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.CharaMotionSetId).HasColumnName("chara_motion_set_id");
            });

            modelBuilder.Entity<SingleModeEventProduction>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("single_mode_event_production");

                entity.Property(e => e.StoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("story_id");

                entity.Property(e => e.EventCategoryId).HasColumnName("event_category_id");

                entity.Property(e => e.MaxItemId).HasColumnName("max_item_id");
            });

            modelBuilder.Entity<SingleModeFanCount>(entity =>
            {
                entity.ToTable("single_mode_fan_count");

                entity.HasIndex(e => e.FanSetId, "single_mode_fan_count_0_fan_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FanCount).HasColumnName("fan_count");

                entity.Property(e => e.FanSetId).HasColumnName("fan_set_id");

                entity.Property(e => e.Order).HasColumnName("order");
            });

            modelBuilder.Entity<SingleModeHintGain>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("single_mode_hint_gain");

                entity.HasIndex(e => e.HintId, "single_mode_hint_gain_0_hint_id");

                entity.Property(e => e.HintGainType).HasColumnName("hint_gain_type");

                entity.Property(e => e.HintGroup).HasColumnName("hint_group");

                entity.Property(e => e.HintId).HasColumnName("hint_id");

                entity.Property(e => e.HintValue1).HasColumnName("hint_value_1");

                entity.Property(e => e.HintValue2).HasColumnName("hint_value_2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SupportCardId).HasColumnName("support_card_id");
            });

            modelBuilder.Entity<SingleModeMessage>(entity =>
            {
                entity.ToTable("single_mode_message");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharacterType).HasColumnName("character_type");

                entity.Property(e => e.Emergent).HasColumnName("emergent");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.StatusType1).HasColumnName("status_type_1");

                entity.Property(e => e.StatusType2).HasColumnName("status_type_2");

                entity.Property(e => e.StatusValue11).HasColumnName("status_value_1_1");

                entity.Property(e => e.StatusValue12).HasColumnName("status_value_1_2");

                entity.Property(e => e.StatusValue21).HasColumnName("status_value_2_1");

                entity.Property(e => e.StatusValue22).HasColumnName("status_value_2_2");
            });

            modelBuilder.Entity<SingleModeNpc>(entity =>
            {
                entity.ToTable("single_mode_npc");

                entity.HasIndex(e => e.NpcGroupId, "single_mode_npc_0_npc_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.Guts).HasColumnName("guts");

                entity.Property(e => e.MobId).HasColumnName("mob_id");

                entity.Property(e => e.MotivationMax).HasColumnName("motivation_max");

                entity.Property(e => e.MotivationMin).HasColumnName("motivation_min");

                entity.Property(e => e.NpcGroupId).HasColumnName("npc_group_id");

                entity.Property(e => e.Pow).HasColumnName("pow");

                entity.Property(e => e.ProperDistanceLong).HasColumnName("proper_distance_long");

                entity.Property(e => e.ProperDistanceMiddle).HasColumnName("proper_distance_middle");

                entity.Property(e => e.ProperDistanceMile).HasColumnName("proper_distance_mile");

                entity.Property(e => e.ProperDistanceShort).HasColumnName("proper_distance_short");

                entity.Property(e => e.ProperGroundDirt).HasColumnName("proper_ground_dirt");

                entity.Property(e => e.ProperGroundTurf).HasColumnName("proper_ground_turf");

                entity.Property(e => e.ProperRunningStyleNige).HasColumnName("proper_running_style_nige");

                entity.Property(e => e.ProperRunningStyleOikomi).HasColumnName("proper_running_style_oikomi");

                entity.Property(e => e.ProperRunningStyleSashi).HasColumnName("proper_running_style_sashi");

                entity.Property(e => e.ProperRunningStyleSenko).HasColumnName("proper_running_style_senko");

                entity.Property(e => e.RaceDressId).HasColumnName("race_dress_id");

                entity.Property(e => e.SkillSetId).HasColumnName("skill_set_id");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.Stamina).HasColumnName("stamina");

                entity.Property(e => e.Wiz).HasColumnName("wiz");
            });

            modelBuilder.Entity<SingleModeOuting>(entity =>
            {
                entity.ToTable("single_mode_outing");

                entity.HasIndex(e => e.CommandGroupId, "single_mode_outing_0_command_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CommandGroupId).HasColumnName("command_group_id");

                entity.Property(e => e.Condition).HasColumnName("condition");

                entity.Property(e => e.IsPlayCutt).HasColumnName("is_play_cutt");
            });

            modelBuilder.Entity<SingleModeOutingSet>(entity =>
            {
                entity.ToTable("single_mode_outing_set");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CommandGroupId1).HasColumnName("command_group_id_1");

                entity.Property(e => e.CommandGroupId2).HasColumnName("command_group_id_2");

                entity.Property(e => e.CommandGroupId3).HasColumnName("command_group_id_3");

                entity.Property(e => e.CommandGroupId4).HasColumnName("command_group_id_4");

                entity.Property(e => e.CommandGroupId5).HasColumnName("command_group_id_5");
            });

            modelBuilder.Entity<SingleModeProgram>(entity =>
            {
                entity.ToTable("single_mode_program");

                entity.HasIndex(e => e.Month, "single_mode_program_0_month");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BaseProgramId).HasColumnName("base_program_id");

                entity.Property(e => e.EntryDecrease).HasColumnName("entry_decrease");

                entity.Property(e => e.EntryDecreaseFlag).HasColumnName("entry_decrease_flag");

                entity.Property(e => e.FanSetId).HasColumnName("fan_set_id");

                entity.Property(e => e.FillyOnlyFlag).HasColumnName("filly_only_flag");

                entity.Property(e => e.GradeRateId).HasColumnName("grade_rate_id");

                entity.Property(e => e.Half).HasColumnName("half");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.NeedFanCount).HasColumnName("need_fan_count");

                entity.Property(e => e.ProgramGroup).HasColumnName("program_group");

                entity.Property(e => e.RaceInstanceId).HasColumnName("race_instance_id");

                entity.Property(e => e.RacePermission).HasColumnName("race_permission");

                entity.Property(e => e.RecommendClassId).HasColumnName("recommend_class_id");

                entity.Property(e => e.RewardSetId).HasColumnName("reward_set_id");
            });

            modelBuilder.Entity<SingleModeRaceGroup>(entity =>
            {
                entity.ToTable("single_mode_race_group");

                entity.HasIndex(e => e.RaceGroupId, "single_mode_race_group_0_race_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.RaceGroupId).HasColumnName("race_group_id");

                entity.Property(e => e.RaceProgramId).HasColumnName("race_program_id");
            });

            modelBuilder.Entity<SingleModeRaceLive>(entity =>
            {
                entity.ToTable("single_mode_race_live");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.MusicId).HasColumnName("music_id");

                entity.Property(e => e.RaceInstanceId).HasColumnName("race_instance_id");
            });

            modelBuilder.Entity<SingleModeRank>(entity =>
            {
                entity.ToTable("single_mode_rank");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MaxValue).HasColumnName("max_value");

                entity.Property(e => e.MinValue).HasColumnName("min_value");
            });

            modelBuilder.Entity<SingleModeRecommend>(entity =>
            {
                entity.ToTable("single_mode_recommend");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GradeLowerLimit).HasColumnName("grade_lower_limit");

                entity.Property(e => e.GradeUpperLimit).HasColumnName("grade_upper_limit");
            });

            modelBuilder.Entity<SingleModeRecommendSetting>(entity =>
            {
                entity.ToTable("single_mode_recommend_setting");

                entity.HasIndex(e => e.RecommendCourseId, "single_mode_recommend_setting_0_recommend_course_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.HeaderFontColor)
                    .IsRequired()
                    .HasColumnName("header_font_color");

                entity.Property(e => e.RecommendCourseId).HasColumnName("recommend_course_id");
            });

            modelBuilder.Entity<SingleModeRewardSet>(entity =>
            {
                entity.ToTable("single_mode_reward_set");

                entity.HasIndex(e => e.RewardSetId, "single_mode_reward_set_0_reward_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Bonus).HasColumnName("bonus");

                entity.Property(e => e.ItemCategory).HasColumnName("item_category");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemNum).HasColumnName("item_num");

                entity.Property(e => e.Odds).HasColumnName("odds");

                entity.Property(e => e.OrderMax).HasColumnName("order_max");

                entity.Property(e => e.OrderMin).HasColumnName("order_min");

                entity.Property(e => e.RewardSetId).HasColumnName("reward_set_id");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<SingleModeRival>(entity =>
            {
                entity.ToTable("single_mode_rival");

                entity.HasIndex(e => new { e.CharaId, e.Turn, e.RaceProgramId, e.RivalCharaId }, "IX_single_mode_rival_chara_id_turn_race_program_id_rival_chara_id")
                    .IsUnique();

                entity.HasIndex(e => e.RaceProgramId, "single_mode_rival_0_race_program_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.ConditionType).HasColumnName("condition_type");

                entity.Property(e => e.RaceProgramId).HasColumnName("race_program_id");

                entity.Property(e => e.RivalCharaId).HasColumnName("rival_chara_id");

                entity.Property(e => e.SingleModeNpcId).HasColumnName("single_mode_npc_id");

                entity.Property(e => e.Turn).HasColumnName("turn");
            });

            modelBuilder.Entity<SingleModeRoute>(entity =>
            {
                entity.ToTable("single_mode_route");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.RaceSetId).HasColumnName("race_set_id");

                entity.Property(e => e.ScenarioId).HasColumnName("scenario_id");
            });

            modelBuilder.Entity<SingleModeRouteRace>(entity =>
            {
                entity.ToTable("single_mode_route_race");

                entity.HasIndex(e => e.RaceSetId, "single_mode_route_race_0_race_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConditionId).HasColumnName("condition_id");

                entity.Property(e => e.ConditionType).HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.DetermineRace).HasColumnName("determine_race");

                entity.Property(e => e.DetermineRaceFlag).HasColumnName("determine_race_flag");

                entity.Property(e => e.RaceSetId).HasColumnName("race_set_id");

                entity.Property(e => e.RaceType).HasColumnName("race_type");

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.TargetType).HasColumnName("target_type");

                entity.Property(e => e.Turn).HasColumnName("turn");
            });

            modelBuilder.Entity<SingleModeScenario>(entity =>
            {
                entity.ToTable("single_mode_scenario");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.PrologueId).HasColumnName("prologue_id");

                entity.Property(e => e.ScenarioImageId).HasColumnName("scenario_image_id");

                entity.Property(e => e.SortId).HasColumnName("sort_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.TurnSetId).HasColumnName("turn_set_id");
            });

            modelBuilder.Entity<SingleModeSkillNeedPoint>(entity =>
            {
                entity.ToTable("single_mode_skill_need_point");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.NeedSkillPoint).HasColumnName("need_skill_point");

                entity.Property(e => e.StatusType).HasColumnName("status_type");

                entity.Property(e => e.StatusValue).HasColumnName("status_value");
            });

            modelBuilder.Entity<SingleModeStoryDatum>(entity =>
            {
                entity.ToTable("single_mode_story_data");

                entity.HasIndex(e => e.CardCharaId, "single_mode_story_data_0_card_chara_id");

                entity.HasIndex(e => e.CardId, "single_mode_story_data_0_card_id");

                entity.HasIndex(e => e.ShortStoryId, "single_mode_story_data_0_short_story_id");

                entity.HasIndex(e => e.StoryId, "single_mode_story_data_0_story_id");

                entity.HasIndex(e => e.SupportCardId, "single_mode_story_data_0_support_card_id");

                entity.HasIndex(e => e.SupportCharaId, "single_mode_story_data_0_support_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CardCharaId).HasColumnName("card_chara_id");

                entity.Property(e => e.CardId).HasColumnName("card_id");

                entity.Property(e => e.EndingType).HasColumnName("ending_type");

                entity.Property(e => e.EventTitleCharaIcon).HasColumnName("event_title_chara_icon");

                entity.Property(e => e.EventTitleDressIcon).HasColumnName("event_title_dress_icon");

                entity.Property(e => e.EventTitleStyle).HasColumnName("event_title_style");

                entity.Property(e => e.MiniGameResult).HasColumnName("mini_game_result");

                entity.Property(e => e.RaceEventFlag).HasColumnName("race_event_flag");

                entity.Property(e => e.SeChange).HasColumnName("se_change");

                entity.Property(e => e.ShortStoryId).HasColumnName("short_story_id");

                entity.Property(e => e.ShowClear).HasColumnName("show_clear");

                entity.Property(e => e.ShowProgress1).HasColumnName("show_progress_1");

                entity.Property(e => e.ShowProgress2).HasColumnName("show_progress_2");

                entity.Property(e => e.ShowSuccession).HasColumnName("show_succession");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.SupportCardId).HasColumnName("support_card_id");

                entity.Property(e => e.SupportCharaId).HasColumnName("support_chara_id");
            });

            modelBuilder.Entity<SingleModeTagCardPo>(entity =>
            {
                entity.ToTable("single_mode_tag_card_pos");

                entity.HasIndex(e => e.SupportCardId, "single_mode_tag_card_pos_0_support_card_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Pattern).HasColumnName("pattern");

                entity.Property(e => e.PosIndex).HasColumnName("pos_index");

                entity.Property(e => e.PosX).HasColumnName("pos_x");

                entity.Property(e => e.PosY).HasColumnName("pos_y");

                entity.Property(e => e.RotZ).HasColumnName("rot_z");

                entity.Property(e => e.ScaleX).HasColumnName("scale_x");

                entity.Property(e => e.ScaleY).HasColumnName("scale_y");

                entity.Property(e => e.SupportCardId).HasColumnName("support_card_id");
            });

            modelBuilder.Entity<SingleModeTopBg>(entity =>
            {
                entity.ToTable("single_mode_top_bg");

                entity.HasIndex(e => e.Month, "single_mode_top_bg_0_month");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BgId).HasColumnName("bg_id");

                entity.Property(e => e.BgSubId).HasColumnName("bg_sub_id");

                entity.Property(e => e.Month).HasColumnName("month");
            });

            modelBuilder.Entity<SingleModeTraining>(entity =>
            {
                entity.ToTable("single_mode_training");

                entity.HasIndex(e => e.CommandId, "single_mode_training_0_command_id");

                entity.HasIndex(e => new { e.CommandId, e.CommandLevel }, "single_mode_training_0_command_id_1_command_level")
                    .IsUnique();

                entity.HasIndex(e => e.CommandType, "single_mode_training_0_command_type");

                entity.HasIndex(e => e.CutinFileId, "single_mode_training_0_cutin_file_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BaseCommandId).HasColumnName("base_command_id");

                entity.Property(e => e.CommandId).HasColumnName("command_id");

                entity.Property(e => e.CommandLevel).HasColumnName("command_level");

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.CutinFileId).HasColumnName("cutin_file_id");

                entity.Property(e => e.DressId).HasColumnName("dress_id");

                entity.Property(e => e.DressType).HasColumnName("dress_type");

                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnName("env_cue_name");

                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnName("env_cuesheet_name");

                entity.Property(e => e.FailureRate).HasColumnName("failure_rate");

                entity.Property(e => e.MaxCharaNum).HasColumnName("max_chara_num");

                entity.Property(e => e.MenuBgId).HasColumnName("menu_bg_id");

                entity.Property(e => e.MenuBgSubId).HasColumnName("menu_bg_sub_id");

                entity.Property(e => e.MotionSet).HasColumnName("motion_set");

                entity.Property(e => e.SaboriType).HasColumnName("sabori_type");
            });

            modelBuilder.Entity<SingleModeTrainingEffect>(entity =>
            {
                entity.ToTable("single_mode_training_effect");

                entity.HasIndex(e => new { e.CommandId, e.ResultState }, "single_mode_training_effect_0_command_id_1_result_state");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CommandId).HasColumnName("command_id");

                entity.Property(e => e.EffectValue).HasColumnName("effect_value");

                entity.Property(e => e.ResultState).HasColumnName("result_state");

                entity.Property(e => e.ScenarioId).HasColumnName("scenario_id");

                entity.Property(e => e.SubId).HasColumnName("sub_id");

                entity.Property(e => e.TargetType).HasColumnName("target_type");
            });

            modelBuilder.Entity<SingleModeTrainingSe>(entity =>
            {
                entity.ToTable("single_mode_training_se");

                entity.HasIndex(e => e.SheetId, "single_mode_training_se_0_sheet_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaIndex).HasColumnName("chara_index");

                entity.Property(e => e.SeCueName)
                    .IsRequired()
                    .HasColumnName("se_cue_name");

                entity.Property(e => e.SeCuesheetName)
                    .IsRequired()
                    .HasColumnName("se_cuesheet_name");

                entity.Property(e => e.SheetId)
                    .IsRequired()
                    .HasColumnName("sheet_id");

                entity.Property(e => e.SkipSeCueName)
                    .IsRequired()
                    .HasColumnName("skip_se_cue_name");

                entity.Property(e => e.SkipSeCuesheetName)
                    .IsRequired()
                    .HasColumnName("skip_se_cuesheet_name");

                entity.Property(e => e.VoiceTriggerId).HasColumnName("voice_trigger_id");
            });

            modelBuilder.Entity<SingleModeTurn>(entity =>
            {
                entity.ToTable("single_mode_turn");

                entity.HasIndex(e => e.TurnSetId, "single_mode_turn_0_turn_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name");

                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name");

                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnName("env_cue_name");

                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnName("env_cuesheet_name");

                entity.Property(e => e.Half).HasColumnName("half");

                entity.Property(e => e.HealthRoomType).HasColumnName("health_room_type");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.OutingSetId).HasColumnName("outing_set_id");

                entity.Property(e => e.Period).HasColumnName("period");

                entity.Property(e => e.RaceEntryType).HasColumnName("race_entry_type");

                entity.Property(e => e.RestType).HasColumnName("rest_type");

                entity.Property(e => e.StoryBgId).HasColumnName("story_bg_id");

                entity.Property(e => e.StoryBgSubId).HasColumnName("story_bg_sub_id");

                entity.Property(e => e.StoryClothId).HasColumnName("story_cloth_id");

                entity.Property(e => e.TopBgId).HasColumnName("top_bg_id");

                entity.Property(e => e.TopClothId).HasColumnName("top_cloth_id");

                entity.Property(e => e.TrainingSetId).HasColumnName("training_set_id");

                entity.Property(e => e.Turn).HasColumnName("turn");

                entity.Property(e => e.TurnSetId).HasColumnName("turn_set_id");

                entity.Property(e => e.UniqueCommand).HasColumnName("unique_command");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<SingleModeUniqueChara>(entity =>
            {
                entity.ToTable("single_mode_unique_chara");

                entity.HasIndex(e => new { e.PartnerId, e.ScenarioId }, "single_mode_unique_chara_0_partner_id_1_scenario_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.PartnerId).HasColumnName("partner_id");

                entity.Property(e => e.Period).HasColumnName("period");

                entity.Property(e => e.ScenarioId).HasColumnName("scenario_id");

                entity.Property(e => e.TrainingPlacement).HasColumnName("training_placement");
            });

            modelBuilder.Entity<SingleModeWinsSaddle>(entity =>
            {
                entity.ToTable("single_mode_wins_saddle");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Condition).HasColumnName("condition");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.RaceInstanceId1).HasColumnName("race_instance_id_1");

                entity.Property(e => e.RaceInstanceId2).HasColumnName("race_instance_id_2");

                entity.Property(e => e.RaceInstanceId3).HasColumnName("race_instance_id_3");

                entity.Property(e => e.RaceInstanceId4).HasColumnName("race_instance_id_4");

                entity.Property(e => e.RaceInstanceId5).HasColumnName("race_instance_id_5");

                entity.Property(e => e.RaceInstanceId6).HasColumnName("race_instance_id_6");

                entity.Property(e => e.RaceInstanceId7).HasColumnName("race_instance_id_7");

                entity.Property(e => e.RaceInstanceId8).HasColumnName("race_instance_id_8");

                entity.Property(e => e.WinSaddleType).HasColumnName("win_saddle_type");
            });

            modelBuilder.Entity<SkillDatum>(entity =>
            {
                entity.ToTable("skill_data");

                entity.HasIndex(e => e.GroupId, "skill_data_0_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AbilityType11).HasColumnName("ability_type_1_1");

                entity.Property(e => e.AbilityType12).HasColumnName("ability_type_1_2");

                entity.Property(e => e.AbilityType13).HasColumnName("ability_type_1_3");

                entity.Property(e => e.AbilityType21).HasColumnName("ability_type_2_1");

                entity.Property(e => e.AbilityType22).HasColumnName("ability_type_2_2");

                entity.Property(e => e.AbilityType23).HasColumnName("ability_type_2_3");

                entity.Property(e => e.AbilityValueLevelUsage11).HasColumnName("ability_value_level_usage_1_1");

                entity.Property(e => e.AbilityValueLevelUsage12).HasColumnName("ability_value_level_usage_1_2");

                entity.Property(e => e.AbilityValueLevelUsage13).HasColumnName("ability_value_level_usage_1_3");

                entity.Property(e => e.AbilityValueLevelUsage21).HasColumnName("ability_value_level_usage_2_1");

                entity.Property(e => e.AbilityValueLevelUsage22).HasColumnName("ability_value_level_usage_2_2");

                entity.Property(e => e.AbilityValueLevelUsage23).HasColumnName("ability_value_level_usage_2_3");

                entity.Property(e => e.AbilityValueUsage11).HasColumnName("ability_value_usage_1_1");

                entity.Property(e => e.AbilityValueUsage12).HasColumnName("ability_value_usage_1_2");

                entity.Property(e => e.AbilityValueUsage13).HasColumnName("ability_value_usage_1_3");

                entity.Property(e => e.AbilityValueUsage21).HasColumnName("ability_value_usage_2_1");

                entity.Property(e => e.AbilityValueUsage22).HasColumnName("ability_value_usage_2_2");

                entity.Property(e => e.AbilityValueUsage23).HasColumnName("ability_value_usage_2_3");

                entity.Property(e => e.ActivateLot).HasColumnName("activate_lot");

                entity.Property(e => e.Condition1)
                    .IsRequired()
                    .HasColumnName("condition_1");

                entity.Property(e => e.Condition2)
                    .IsRequired()
                    .HasColumnName("condition_2");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.ExpType).HasColumnName("exp_type");

                entity.Property(e => e.FilterSwitch).HasColumnName("filter_switch");

                entity.Property(e => e.FloatAbilityTime1).HasColumnName("float_ability_time_1");

                entity.Property(e => e.FloatAbilityTime2).HasColumnName("float_ability_time_2");

                entity.Property(e => e.FloatAbilityValue11).HasColumnName("float_ability_value_1_1");

                entity.Property(e => e.FloatAbilityValue12).HasColumnName("float_ability_value_1_2");

                entity.Property(e => e.FloatAbilityValue13).HasColumnName("float_ability_value_1_3");

                entity.Property(e => e.FloatAbilityValue21).HasColumnName("float_ability_value_2_1");

                entity.Property(e => e.FloatAbilityValue22).HasColumnName("float_ability_value_2_2");

                entity.Property(e => e.FloatAbilityValue23).HasColumnName("float_ability_value_2_3");

                entity.Property(e => e.FloatCooldownTime1).HasColumnName("float_cooldown_time_1");

                entity.Property(e => e.FloatCooldownTime2).HasColumnName("float_cooldown_time_2");

                entity.Property(e => e.GradeValue).HasColumnName("grade_value");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.GroupRate).HasColumnName("group_rate");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.PopularityAddParam1).HasColumnName("popularity_add_param_1");

                entity.Property(e => e.PopularityAddParam2).HasColumnName("popularity_add_param_2");

                entity.Property(e => e.PopularityAddValue1).HasColumnName("popularity_add_value_1");

                entity.Property(e => e.PopularityAddValue2).HasColumnName("popularity_add_value_2");

                entity.Property(e => e.PotentialPerDefault).HasColumnName("potential_per_default");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.SkillCategory).HasColumnName("skill_category");

                entity.Property(e => e.TagId)
                    .IsRequired()
                    .HasColumnName("tag_id");

                entity.Property(e => e.TargetType11).HasColumnName("target_type_1_1");

                entity.Property(e => e.TargetType12).HasColumnName("target_type_1_2");

                entity.Property(e => e.TargetType13).HasColumnName("target_type_1_3");

                entity.Property(e => e.TargetType21).HasColumnName("target_type_2_1");

                entity.Property(e => e.TargetType22).HasColumnName("target_type_2_2");

                entity.Property(e => e.TargetType23).HasColumnName("target_type_2_3");

                entity.Property(e => e.TargetValue11).HasColumnName("target_value_1_1");

                entity.Property(e => e.TargetValue12).HasColumnName("target_value_1_2");

                entity.Property(e => e.TargetValue13).HasColumnName("target_value_1_3");

                entity.Property(e => e.TargetValue21).HasColumnName("target_value_2_1");

                entity.Property(e => e.TargetValue22).HasColumnName("target_value_2_2");

                entity.Property(e => e.TargetValue23).HasColumnName("target_value_2_3");

                entity.Property(e => e.UniqueSkillId1).HasColumnName("unique_skill_id_1");

                entity.Property(e => e.UniqueSkillId2).HasColumnName("unique_skill_id_2");
            });

            modelBuilder.Entity<SkillExp>(entity =>
            {
                entity.ToTable("skill_exp");

                entity.HasIndex(e => e.Type, "skill_exp_0_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Scale).HasColumnName("scale");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<SkillLevelValue>(entity =>
            {
                entity.ToTable("skill_level_value");

                entity.HasIndex(e => e.AbilityType, "skill_level_value_0_ability_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AbilityType).HasColumnName("ability_type");

                entity.Property(e => e.FloatAbilityValueCoef).HasColumnName("float_ability_value_coef");

                entity.Property(e => e.Level).HasColumnName("level");
            });

            modelBuilder.Entity<SkillRarity>(entity =>
            {
                entity.ToTable("skill_rarity");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<SkillSet>(entity =>
            {
                entity.ToTable("skill_set");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.SkillId1).HasColumnName("skill_id1");

                entity.Property(e => e.SkillId10).HasColumnName("skill_id10");

                entity.Property(e => e.SkillId2).HasColumnName("skill_id2");

                entity.Property(e => e.SkillId3).HasColumnName("skill_id3");

                entity.Property(e => e.SkillId4).HasColumnName("skill_id4");

                entity.Property(e => e.SkillId5).HasColumnName("skill_id5");

                entity.Property(e => e.SkillId6).HasColumnName("skill_id6");

                entity.Property(e => e.SkillId7).HasColumnName("skill_id7");

                entity.Property(e => e.SkillId8).HasColumnName("skill_id8");

                entity.Property(e => e.SkillId9).HasColumnName("skill_id9");

                entity.Property(e => e.SkillLevel1).HasColumnName("skill_level1");

                entity.Property(e => e.SkillLevel10).HasColumnName("skill_level10");

                entity.Property(e => e.SkillLevel2).HasColumnName("skill_level2");

                entity.Property(e => e.SkillLevel3).HasColumnName("skill_level3");

                entity.Property(e => e.SkillLevel4).HasColumnName("skill_level4");

                entity.Property(e => e.SkillLevel5).HasColumnName("skill_level5");

                entity.Property(e => e.SkillLevel6).HasColumnName("skill_level6");

                entity.Property(e => e.SkillLevel7).HasColumnName("skill_level7");

                entity.Property(e => e.SkillLevel8).HasColumnName("skill_level8");

                entity.Property(e => e.SkillLevel9).HasColumnName("skill_level9");
            });

            modelBuilder.Entity<StoryEventBingoReward>(entity =>
            {
                entity.ToTable("story_event_bingo_reward");

                entity.HasIndex(e => e.RewardSetId, "story_event_bingo_reward_0_reward_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ItemCategory).HasColumnName("item_category");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemNum).HasColumnName("item_num");

                entity.Property(e => e.LineNum).HasColumnName("line_num");

                entity.Property(e => e.RewardSetId).HasColumnName("reward_set_id");
            });

            modelBuilder.Entity<StoryEventBonusCard>(entity =>
            {
                entity.ToTable("story_event_bonus_card");

                entity.HasIndex(e => new { e.StoryEventId, e.CharaId, e.CardId }, "IX_story_event_bonus_card_story_event_id_chara_id_card_id")
                    .IsUnique();

                entity.HasIndex(e => e.StoryEventId, "story_event_bonus_card_0_story_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CardId).HasColumnName("card_id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.Rarity1).HasColumnName("rarity_1");

                entity.Property(e => e.Rarity2).HasColumnName("rarity_2");

                entity.Property(e => e.Rarity3).HasColumnName("rarity_3");

                entity.Property(e => e.Rarity4).HasColumnName("rarity_4");

                entity.Property(e => e.Rarity5).HasColumnName("rarity_5");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StoryEventId).HasColumnName("story_event_id");
            });

            modelBuilder.Entity<StoryEventBonusSupportCard>(entity =>
            {
                entity.ToTable("story_event_bonus_support_card");

                entity.HasIndex(e => new { e.StoryEventId, e.CharaId, e.Rarity, e.SupportCardId }, "IX_story_event_bonus_support_card_story_event_id_chara_id_rarity_support_card_id")
                    .IsUnique();

                entity.HasIndex(e => e.StoryEventId, "story_event_bonus_support_card_0_story_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.Limit0).HasColumnName("limit_0");

                entity.Property(e => e.Limit1).HasColumnName("limit_1");

                entity.Property(e => e.Limit2).HasColumnName("limit_2");

                entity.Property(e => e.Limit3).HasColumnName("limit_3");

                entity.Property(e => e.Limit4).HasColumnName("limit_4");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StoryEventId).HasColumnName("story_event_id");

                entity.Property(e => e.SupportCardId).HasColumnName("support_card_id");
            });

            modelBuilder.Entity<StoryEventDatum>(entity =>
            {
                entity.HasKey(e => e.StoryEventId);

                entity.ToTable("story_event_data");

                entity.Property(e => e.StoryEventId)
                    .ValueGeneratedNever()
                    .HasColumnName("story_event_id");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.EndingDate).HasColumnName("ending_date");

                entity.Property(e => e.MiddleDate01).HasColumnName("middle_date_01");

                entity.Property(e => e.MiddleDate02).HasColumnName("middle_date_02");

                entity.Property(e => e.NoticeDate).HasColumnName("notice_date");

                entity.Property(e => e.StartDate).HasColumnName("start_date");
            });

            modelBuilder.Entity<StoryEventMission>(entity =>
            {
                entity.ToTable("story_event_mission");

                entity.HasIndex(e => e.StoryEventId, "story_event_mission_0_story_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionType).HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.ConditionValue4).HasColumnName("condition_value_4");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.ItemCategory).HasColumnName("item_category");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemNum).HasColumnName("item_num");

                entity.Property(e => e.MissionType).HasColumnName("mission_type");

                entity.Property(e => e.StepGroupId).HasColumnName("step_group_id");

                entity.Property(e => e.StepOrder).HasColumnName("step_order");

                entity.Property(e => e.StoryEventId).HasColumnName("story_event_id");

                entity.Property(e => e.TransitionType).HasColumnName("transition_type");
            });

            modelBuilder.Entity<StoryEventMissionTopChara>(entity =>
            {
                entity.ToTable("story_event_mission_top_chara");

                entity.HasIndex(e => e.StoryEventId, "story_event_mission_top_chara_0_story_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name");

                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.DressId).HasColumnName("dress_id");

                entity.Property(e => e.EndingFlag).HasColumnName("ending_flag");

                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnName("env_cue_name");

                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnName("env_cuesheet_name");

                entity.Property(e => e.MenuBgId).HasColumnName("menu_bg_id");

                entity.Property(e => e.MenuBgSubId).HasColumnName("menu_bg_sub_id");

                entity.Property(e => e.StoryEventId).HasColumnName("story_event_id");
            });

            modelBuilder.Entity<StoryEventNicknameBonu>(entity =>
            {
                entity.ToTable("story_event_nickname_bonus");

                entity.HasIndex(e => new { e.StoryEventId, e.NicknameRank }, "IX_story_event_nickname_bonus_story_event_id_nickname_rank")
                    .IsUnique();

                entity.HasIndex(e => e.StoryEventId, "story_event_nickname_bonus_0_story_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BonusPoint).HasColumnName("bonus_point");

                entity.Property(e => e.NicknameRank).HasColumnName("nickname_rank");

                entity.Property(e => e.StoryEventId).HasColumnName("story_event_id");
            });

            modelBuilder.Entity<StoryEventPointReward>(entity =>
            {
                entity.ToTable("story_event_point_reward");

                entity.HasIndex(e => e.StoryEventId, "story_event_point_reward_0_story_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ItemCategory).HasColumnName("item_category");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemNum).HasColumnName("item_num");

                entity.Property(e => e.Point).HasColumnName("point");

                entity.Property(e => e.StoryEventId).HasColumnName("story_event_id");
            });

            modelBuilder.Entity<StoryEventRouletteBingo>(entity =>
            {
                entity.ToTable("story_event_roulette_bingo");

                entity.HasIndex(e => new { e.RouletteId, e.StoryEventId, e.SheetNum }, "IX_story_event_roulette_bingo_roulette_id_story_event_id_sheet_num")
                    .IsUnique();

                entity.HasIndex(e => e.StoryEventId, "story_event_roulette_bingo_0_story_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CanLoop).HasColumnName("can_loop");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.DressId).HasColumnName("dress_id");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.ResetLine).HasColumnName("reset_line");

                entity.Property(e => e.RewardSetId).HasColumnName("reward_set_id");

                entity.Property(e => e.RouletteId).HasColumnName("roulette_id");

                entity.Property(e => e.SheetNum).HasColumnName("sheet_num");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StoryEventId).HasColumnName("story_event_id");

                entity.Property(e => e.UseItemCategory).HasColumnName("use_item_category");

                entity.Property(e => e.UseItemId).HasColumnName("use_item_id");

                entity.Property(e => e.UseItemNum).HasColumnName("use_item_num");
            });

            modelBuilder.Entity<StoryEventStoryDatum>(entity =>
            {
                entity.ToTable("story_event_story_data");

                entity.HasIndex(e => e.StoryEventId, "story_event_story_data_0_story_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AddRewardCategory1).HasColumnName("add_reward_category_1");

                entity.Property(e => e.AddRewardId1).HasColumnName("add_reward_id_1");

                entity.Property(e => e.AddRewardNum1).HasColumnName("add_reward_num_1");

                entity.Property(e => e.EpisodeIndexId).HasColumnName("episode_index_id");

                entity.Property(e => e.NeedPoint).HasColumnName("need_point");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.StoryConditionType).HasColumnName("story_condition_type");

                entity.Property(e => e.StoryEventId).HasColumnName("story_event_id");

                entity.Property(e => e.StoryId1).HasColumnName("story_id_1");
            });

            modelBuilder.Entity<StoryEventTopChara>(entity =>
            {
                entity.ToTable("story_event_top_chara");

                entity.HasIndex(e => e.StoryEventId, "story_event_top_chara_0_story_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name");

                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnName("bgm_cuesheet_name");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.DressId).HasColumnName("dress_id");

                entity.Property(e => e.EndingFlag).HasColumnName("ending_flag");

                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnName("env_cue_name");

                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnName("env_cuesheet_name");

                entity.Property(e => e.MaxEpisodeIndex).HasColumnName("max_episode_index");

                entity.Property(e => e.MenuBgId).HasColumnName("menu_bg_id");

                entity.Property(e => e.MenuBgSubId).HasColumnName("menu_bg_sub_id");

                entity.Property(e => e.MinEpisodeIndex).HasColumnName("min_episode_index");

                entity.Property(e => e.StoryEventId).HasColumnName("story_event_id");
            });

            modelBuilder.Entity<StoryEventWinBonu>(entity =>
            {
                entity.ToTable("story_event_win_bonus");

                entity.HasIndex(e => e.StoryEventId, "story_event_win_bonus_0_story_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BonusPoint).HasColumnName("bonus_point");

                entity.Property(e => e.MaxWinCount).HasColumnName("max_win_count");

                entity.Property(e => e.MinWinCount).HasColumnName("min_win_count");

                entity.Property(e => e.StoryEventId).HasColumnName("story_event_id");
            });

            modelBuilder.Entity<StoryLiveSet>(entity =>
            {
                entity.ToTable("story_live_set");

                entity.HasIndex(e => e.MusicId, "story_live_set_0_music_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId1).HasColumnName("chara_id_1");

                entity.Property(e => e.CharaId10).HasColumnName("chara_id_10");

                entity.Property(e => e.CharaId11).HasColumnName("chara_id_11");

                entity.Property(e => e.CharaId12).HasColumnName("chara_id_12");

                entity.Property(e => e.CharaId13).HasColumnName("chara_id_13");

                entity.Property(e => e.CharaId14).HasColumnName("chara_id_14");

                entity.Property(e => e.CharaId15).HasColumnName("chara_id_15");

                entity.Property(e => e.CharaId16).HasColumnName("chara_id_16");

                entity.Property(e => e.CharaId17).HasColumnName("chara_id_17");

                entity.Property(e => e.CharaId18).HasColumnName("chara_id_18");

                entity.Property(e => e.CharaId2).HasColumnName("chara_id_2");

                entity.Property(e => e.CharaId3).HasColumnName("chara_id_3");

                entity.Property(e => e.CharaId4).HasColumnName("chara_id_4");

                entity.Property(e => e.CharaId5).HasColumnName("chara_id_5");

                entity.Property(e => e.CharaId6).HasColumnName("chara_id_6");

                entity.Property(e => e.CharaId7).HasColumnName("chara_id_7");

                entity.Property(e => e.CharaId8).HasColumnName("chara_id_8");

                entity.Property(e => e.CharaId9).HasColumnName("chara_id_9");

                entity.Property(e => e.CharaType1).HasColumnName("chara_type_1");

                entity.Property(e => e.CharaType10).HasColumnName("chara_type_10");

                entity.Property(e => e.CharaType11).HasColumnName("chara_type_11");

                entity.Property(e => e.CharaType12).HasColumnName("chara_type_12");

                entity.Property(e => e.CharaType13).HasColumnName("chara_type_13");

                entity.Property(e => e.CharaType14).HasColumnName("chara_type_14");

                entity.Property(e => e.CharaType15).HasColumnName("chara_type_15");

                entity.Property(e => e.CharaType16).HasColumnName("chara_type_16");

                entity.Property(e => e.CharaType17).HasColumnName("chara_type_17");

                entity.Property(e => e.CharaType18).HasColumnName("chara_type_18");

                entity.Property(e => e.CharaType2).HasColumnName("chara_type_2");

                entity.Property(e => e.CharaType3).HasColumnName("chara_type_3");

                entity.Property(e => e.CharaType4).HasColumnName("chara_type_4");

                entity.Property(e => e.CharaType5).HasColumnName("chara_type_5");

                entity.Property(e => e.CharaType6).HasColumnName("chara_type_6");

                entity.Property(e => e.CharaType7).HasColumnName("chara_type_7");

                entity.Property(e => e.CharaType8).HasColumnName("chara_type_8");

                entity.Property(e => e.CharaType9).HasColumnName("chara_type_9");

                entity.Property(e => e.DressColor1).HasColumnName("dress_color_1");

                entity.Property(e => e.DressColor10).HasColumnName("dress_color_10");

                entity.Property(e => e.DressColor11).HasColumnName("dress_color_11");

                entity.Property(e => e.DressColor12).HasColumnName("dress_color_12");

                entity.Property(e => e.DressColor13).HasColumnName("dress_color_13");

                entity.Property(e => e.DressColor14).HasColumnName("dress_color_14");

                entity.Property(e => e.DressColor15).HasColumnName("dress_color_15");

                entity.Property(e => e.DressColor16).HasColumnName("dress_color_16");

                entity.Property(e => e.DressColor17).HasColumnName("dress_color_17");

                entity.Property(e => e.DressColor18).HasColumnName("dress_color_18");

                entity.Property(e => e.DressColor2).HasColumnName("dress_color_2");

                entity.Property(e => e.DressColor3).HasColumnName("dress_color_3");

                entity.Property(e => e.DressColor4).HasColumnName("dress_color_4");

                entity.Property(e => e.DressColor5).HasColumnName("dress_color_5");

                entity.Property(e => e.DressColor6).HasColumnName("dress_color_6");

                entity.Property(e => e.DressColor7).HasColumnName("dress_color_7");

                entity.Property(e => e.DressColor8).HasColumnName("dress_color_8");

                entity.Property(e => e.DressColor9).HasColumnName("dress_color_9");

                entity.Property(e => e.DressId1).HasColumnName("dress_id_1");

                entity.Property(e => e.DressId10).HasColumnName("dress_id_10");

                entity.Property(e => e.DressId11).HasColumnName("dress_id_11");

                entity.Property(e => e.DressId12).HasColumnName("dress_id_12");

                entity.Property(e => e.DressId13).HasColumnName("dress_id_13");

                entity.Property(e => e.DressId14).HasColumnName("dress_id_14");

                entity.Property(e => e.DressId15).HasColumnName("dress_id_15");

                entity.Property(e => e.DressId16).HasColumnName("dress_id_16");

                entity.Property(e => e.DressId17).HasColumnName("dress_id_17");

                entity.Property(e => e.DressId18).HasColumnName("dress_id_18");

                entity.Property(e => e.DressId2).HasColumnName("dress_id_2");

                entity.Property(e => e.DressId3).HasColumnName("dress_id_3");

                entity.Property(e => e.DressId4).HasColumnName("dress_id_4");

                entity.Property(e => e.DressId5).HasColumnName("dress_id_5");

                entity.Property(e => e.DressId6).HasColumnName("dress_id_6");

                entity.Property(e => e.DressId7).HasColumnName("dress_id_7");

                entity.Property(e => e.DressId8).HasColumnName("dress_id_8");

                entity.Property(e => e.DressId9).HasColumnName("dress_id_9");

                entity.Property(e => e.MusicId).HasColumnName("music_id");

                entity.Property(e => e.VocalCharaId1).HasColumnName("vocal_chara_id_1");

                entity.Property(e => e.VocalCharaId2).HasColumnName("vocal_chara_id_2");

                entity.Property(e => e.VocalCharaId3).HasColumnName("vocal_chara_id_3");

                entity.Property(e => e.VocalCharaId4).HasColumnName("vocal_chara_id_4");

                entity.Property(e => e.VocalCharaId5).HasColumnName("vocal_chara_id_5");
            });

            modelBuilder.Entity<StoryStill>(entity =>
            {
                entity.ToTable("story_still");

                entity.HasIndex(e => e.StillId, "story_still_0_still_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.PageId).HasColumnName("page_id");

                entity.Property(e => e.StillId).HasColumnName("still_id");
            });

            modelBuilder.Entity<SuccessionFactor>(entity =>
            {
                entity.HasKey(e => e.FactorId);

                entity.ToTable("succession_factor");

                entity.HasIndex(e => new { e.FactorGroupId, e.Rarity }, "succession_factor_0_factor_group_id_1_rarity")
                    .IsUnique();

                entity.Property(e => e.FactorId)
                    .ValueGeneratedNever()
                    .HasColumnName("factor_id");

                entity.Property(e => e.EffectGroupId).HasColumnName("effect_group_id");

                entity.Property(e => e.FactorGroupId).HasColumnName("factor_group_id");

                entity.Property(e => e.FactorType).HasColumnName("factor_type");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.Rarity).HasColumnName("rarity");
            });

            modelBuilder.Entity<SuccessionFactorEffect>(entity =>
            {
                entity.ToTable("succession_factor_effect");

                entity.HasIndex(e => e.FactorGroupId, "succession_factor_effect_0_factor_group_id");

                entity.HasIndex(e => new { e.FactorGroupId, e.EffectId }, "succession_factor_effect_0_factor_group_id_1_effect_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EffectId).HasColumnName("effect_id");

                entity.Property(e => e.FactorGroupId).HasColumnName("factor_group_id");

                entity.Property(e => e.TargetType).HasColumnName("target_type");

                entity.Property(e => e.Value1).HasColumnName("value_1");

                entity.Property(e => e.Value2).HasColumnName("value_2");
            });

            modelBuilder.Entity<SuccessionInitialFactor>(entity =>
            {
                entity.ToTable("succession_initial_factor");

                entity.HasIndex(e => e.FactorType, "succession_initial_factor_0_factor_type");

                entity.HasIndex(e => new { e.FactorType, e.Value1 }, "succession_initial_factor_0_factor_type_1_value_1");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AddPoint).HasColumnName("add_point");

                entity.Property(e => e.FactorType).HasColumnName("factor_type");

                entity.Property(e => e.Value1).HasColumnName("value_1");

                entity.Property(e => e.Value2).HasColumnName("value_2");
            });

            modelBuilder.Entity<SuccessionRelation>(entity =>
            {
                entity.HasKey(e => e.RelationType);

                entity.ToTable("succession_relation");

                entity.Property(e => e.RelationType)
                    .ValueGeneratedNever()
                    .HasColumnName("relation_type");

                entity.Property(e => e.RelationPoint).HasColumnName("relation_point");
            });

            modelBuilder.Entity<SuccessionRelationMember>(entity =>
            {
                entity.ToTable("succession_relation_member");

                entity.HasIndex(e => e.CharaId, "succession_relation_member_0_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.RelationType).HasColumnName("relation_type");
            });

            modelBuilder.Entity<SuccessionRelationRank>(entity =>
            {
                entity.HasKey(e => e.RelationRank);

                entity.ToTable("succession_relation_rank");

                entity.Property(e => e.RelationRank)
                    .ValueGeneratedNever()
                    .HasColumnName("relation_rank");

                entity.Property(e => e.RankValueMax).HasColumnName("rank_value_max");

                entity.Property(e => e.RankValueMin).HasColumnName("rank_value_min");
            });

            modelBuilder.Entity<SuccessionRental>(entity =>
            {
                entity.ToTable("succession_rental");

                entity.HasIndex(e => new { e.RentalRank, e.RentalNum }, "succession_rental_0_rental_rank_1_rental_num");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.RentalNum).HasColumnName("rental_num");

                entity.Property(e => e.RentalRank).HasColumnName("rental_rank");

                entity.Property(e => e.UseValue1).HasColumnName("use_value1");

                entity.Property(e => e.UseValue2).HasColumnName("use_value2");
            });

            modelBuilder.Entity<SupportCardDatum>(entity =>
            {
                entity.ToTable("support_card_data");

                entity.HasIndex(e => e.CharaId, "support_card_data_0_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.CommandId).HasColumnName("command_id");

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DetailPosX).HasColumnName("detail_pos_x");

                entity.Property(e => e.DetailPosY).HasColumnName("detail_pos_y");

                entity.Property(e => e.DetailRotZ).HasColumnName("detail_rot_z");

                entity.Property(e => e.DetailScale).HasColumnName("detail_scale");

                entity.Property(e => e.EffectTableId).HasColumnName("effect_table_id");

                entity.Property(e => e.ExchangeItemId).HasColumnName("exchange_item_id");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.SkillSetId).HasColumnName("skill_set_id");

                entity.Property(e => e.SupportCardType).HasColumnName("support_card_type");

                entity.Property(e => e.UniqueEffectId).HasColumnName("unique_effect_id");
            });

            modelBuilder.Entity<SupportCardEffectTable>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Type });

                entity.ToTable("support_card_effect_table");

                entity.HasIndex(e => e.Id, "support_card_effect_table_0_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Init).HasColumnName("init");

                entity.Property(e => e.LimitLv10).HasColumnName("limit_lv10");

                entity.Property(e => e.LimitLv15).HasColumnName("limit_lv15");

                entity.Property(e => e.LimitLv20).HasColumnName("limit_lv20");

                entity.Property(e => e.LimitLv25).HasColumnName("limit_lv25");

                entity.Property(e => e.LimitLv30).HasColumnName("limit_lv30");

                entity.Property(e => e.LimitLv35).HasColumnName("limit_lv35");

                entity.Property(e => e.LimitLv40).HasColumnName("limit_lv40");

                entity.Property(e => e.LimitLv45).HasColumnName("limit_lv45");

                entity.Property(e => e.LimitLv5).HasColumnName("limit_lv5");

                entity.Property(e => e.LimitLv50).HasColumnName("limit_lv50");
            });

            modelBuilder.Entity<SupportCardLevel>(entity =>
            {
                entity.ToTable("support_card_level");

                entity.HasIndex(e => new { e.Rarity, e.Level }, "IX_support_card_level_rarity_level")
                    .IsUnique();

                entity.HasIndex(e => e.Rarity, "support_card_level_0_rarity");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.TotalExp).HasColumnName("total_exp");
            });

            modelBuilder.Entity<SupportCardLimit>(entity =>
            {
                entity.HasKey(e => e.Rarity);

                entity.ToTable("support_card_limit");

                entity.Property(e => e.Rarity)
                    .ValueGeneratedNever()
                    .HasColumnName("rarity");

                entity.Property(e => e.Limit0).HasColumnName("limit_0");

                entity.Property(e => e.Limit1).HasColumnName("limit_1");

                entity.Property(e => e.Limit2).HasColumnName("limit_2");

                entity.Property(e => e.Limit3).HasColumnName("limit_3");

                entity.Property(e => e.Limit4).HasColumnName("limit_4");
            });

            modelBuilder.Entity<SupportCardTeamScoreBonu>(entity =>
            {
                entity.ToTable("support_card_team_score_bonus");

                entity.HasIndex(e => e.Level, "support_card_team_score_bonus_0_level");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.ScoreRate).HasColumnName("score_rate");
            });

            modelBuilder.Entity<SupportCardUniqueEffect>(entity =>
            {
                entity.ToTable("support_card_unique_effect");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Lv).HasColumnName("lv");

                entity.Property(e => e.Type0).HasColumnName("type_0");

                entity.Property(e => e.Type1).HasColumnName("type_1");

                entity.Property(e => e.Value0).HasColumnName("value_0");

                entity.Property(e => e.Value1).HasColumnName("value_1");
            });

            modelBuilder.Entity<TeamStadium>(entity =>
            {
                entity.ToTable("team_stadium");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CalcEndDate).HasColumnName("calc_end_date");

                entity.Property(e => e.CalcEndTime)
                    .IsRequired()
                    .HasColumnName("calc_end_time");

                entity.Property(e => e.CalcStartDate).HasColumnName("calc_start_date");

                entity.Property(e => e.CalcStartTime)
                    .IsRequired()
                    .HasColumnName("calc_start_time");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnName("end_date");

                entity.Property(e => e.IntervalEndDate).HasColumnName("interval_end_date");

                entity.Property(e => e.IntervalEndTime)
                    .IsRequired()
                    .HasColumnName("interval_end_time");

                entity.Property(e => e.IntervalStartDate).HasColumnName("interval_start_date");

                entity.Property(e => e.IntervalStartTime)
                    .IsRequired()
                    .HasColumnName("interval_start_time");

                entity.Property(e => e.RaceEndDate).HasColumnName("race_end_date");

                entity.Property(e => e.RaceEndTime)
                    .IsRequired()
                    .HasColumnName("race_end_time");

                entity.Property(e => e.RaceStartDate).HasColumnName("race_start_date");

                entity.Property(e => e.RaceStartTime)
                    .IsRequired()
                    .HasColumnName("race_start_time");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<TeamStadiumBgm>(entity =>
            {
                entity.ToTable("team_stadium_bgm");

                entity.HasIndex(e => e.SceneType, "team_stadium_bgm_0_scene_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnName("cue_name");

                entity.Property(e => e.CuesheetName)
                    .IsRequired()
                    .HasColumnName("cuesheet_name");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.SceneType).HasColumnName("scene_type");
            });

            modelBuilder.Entity<TeamStadiumClass>(entity =>
            {
                entity.ToTable("team_stadium_class");

                entity.HasIndex(e => e.TeamStadiumId, "team_stadium_class_0_team_stadium_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ClassDownRange).HasColumnName("class_down_range");

                entity.Property(e => e.ClassUpRange).HasColumnName("class_up_range");

                entity.Property(e => e.TeamClass).HasColumnName("team_class");

                entity.Property(e => e.TeamStadiumId).HasColumnName("team_stadium_id");

                entity.Property(e => e.UnitMaxNum).HasColumnName("unit_max_num");
            });

            modelBuilder.Entity<TeamStadiumClassReward>(entity =>
            {
                entity.ToTable("team_stadium_class_reward");

                entity.HasIndex(e => new { e.TeamStadiumId, e.ClassRewardType }, "team_stadium_class_reward_0_team_stadium_id_1_class_reward_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ClassRewardType).HasColumnName("class_reward_type");

                entity.Property(e => e.ItemCategory1).HasColumnName("item_category_1");

                entity.Property(e => e.ItemCategory2).HasColumnName("item_category_2");

                entity.Property(e => e.ItemCategory3).HasColumnName("item_category_3");

                entity.Property(e => e.ItemCategory4).HasColumnName("item_category_4");

                entity.Property(e => e.ItemCategory5).HasColumnName("item_category_5");

                entity.Property(e => e.ItemId1).HasColumnName("item_id_1");

                entity.Property(e => e.ItemId2).HasColumnName("item_id_2");

                entity.Property(e => e.ItemId3).HasColumnName("item_id_3");

                entity.Property(e => e.ItemId4).HasColumnName("item_id_4");

                entity.Property(e => e.ItemId5).HasColumnName("item_id_5");

                entity.Property(e => e.ItemNum1).HasColumnName("item_num_1");

                entity.Property(e => e.ItemNum2).HasColumnName("item_num_2");

                entity.Property(e => e.ItemNum3).HasColumnName("item_num_3");

                entity.Property(e => e.ItemNum4).HasColumnName("item_num_4");

                entity.Property(e => e.ItemNum5).HasColumnName("item_num_5");

                entity.Property(e => e.TeamClass).HasColumnName("team_class");

                entity.Property(e => e.TeamStadiumId).HasColumnName("team_stadium_id");
            });

            modelBuilder.Entity<TeamStadiumEvaluationRate>(entity =>
            {
                entity.HasKey(e => new { e.ProperType, e.ProperRank });

                entity.ToTable("team_stadium_evaluation_rate");

                entity.Property(e => e.ProperType).HasColumnName("proper_type");

                entity.Property(e => e.ProperRank).HasColumnName("proper_rank");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Rate).HasColumnName("rate");
            });

            modelBuilder.Entity<TeamStadiumRaceResultMotion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("team_stadium_race_result_motion");

                entity.HasIndex(e => e.CharacterId, "team_stadium_race_result_motion_0_character_id");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.Draw1).HasColumnName("draw_1");

                entity.Property(e => e.Draw2).HasColumnName("draw_2");

                entity.Property(e => e.Draw3).HasColumnName("draw_3");

                entity.Property(e => e.Draw4).HasColumnName("draw_4");

                entity.Property(e => e.Draw5).HasColumnName("draw_5");

                entity.Property(e => e.Lose1).HasColumnName("lose_1");

                entity.Property(e => e.Lose2).HasColumnName("lose_2");

                entity.Property(e => e.Lose3).HasColumnName("lose_3");

                entity.Property(e => e.Lose4).HasColumnName("lose_4");

                entity.Property(e => e.Lose5).HasColumnName("lose_5");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.Win1).HasColumnName("win_1");

                entity.Property(e => e.Win2).HasColumnName("win_2");

                entity.Property(e => e.Win2PositionY).HasColumnName("win_2_position_y");

                entity.Property(e => e.Win3).HasColumnName("win_3");

                entity.Property(e => e.Win3PositionY).HasColumnName("win_3_position_y");

                entity.Property(e => e.Win4).HasColumnName("win_4");

                entity.Property(e => e.Win4PositionY).HasColumnName("win_4_position_y");

                entity.Property(e => e.Win5).HasColumnName("win_5");
            });

            modelBuilder.Entity<TeamStadiumRank>(entity =>
            {
                entity.ToTable("team_stadium_rank");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ItemCategory).HasColumnName("item_category");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemNum).HasColumnName("item_num");

                entity.Property(e => e.TeamMaxValue).HasColumnName("team_max_value");

                entity.Property(e => e.TeamMinValue).HasColumnName("team_min_value");

                entity.Property(e => e.TeamRank).HasColumnName("team_rank");

                entity.Property(e => e.TeamRankGroup).HasColumnName("team_rank_group");
            });

            modelBuilder.Entity<TeamStadiumRawScore>(entity =>
            {
                entity.ToTable("team_stadium_raw_score");

                entity.HasIndex(e => e.ConditionType, "team_stadium_raw_score_0_condition_type");

                entity.HasIndex(e => e.RaceScoreNameId, "team_stadium_raw_score_0_race_score_name_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConditionType).HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.RaceScoreNameId).HasColumnName("race_score_name_id");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<TeamStadiumScoreBonu>(entity =>
            {
                entity.ToTable("team_stadium_score_bonus");

                entity.HasIndex(e => e.ConditionType, "team_stadium_score_bonus_0_condition_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConditionType).HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.ScoreRate).HasColumnName("score_rate");
            });

            modelBuilder.Entity<TeamStadiumStandMotion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("team_stadium_stand_motion");

                entity.HasIndex(e => new { e.CharacterId, e.Type }, "team_stadium_stand_motion_0_character_id_1_type");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.MotionSet).HasColumnName("motion_set");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.RaceDressId).HasColumnName("race_dress_id");

                entity.Property(e => e.Rotation).HasColumnName("rotation");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<TeamStadiumSupportText>(entity =>
            {
                entity.ToTable("team_stadium_support_text");

                entity.HasIndex(e => e.Type, "team_stadium_support_text_0_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MaxBonus).HasColumnName("max_bonus");

                entity.Property(e => e.MinBonus).HasColumnName("min_bonus");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<TextDatum>(entity =>
            {
                entity.HasKey(e => new { e.Category, e.Index });

                entity.ToTable("text_data");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");
            });

            modelBuilder.Entity<TimezoneDatum>(entity =>
            {
                entity.HasKey(e => e.Timezone);

                entity.ToTable("timezone_data");

                entity.Property(e => e.Timezone)
                    .ValueGeneratedNever()
                    .HasColumnName("timezone");

                entity.Property(e => e.EndHour)
                    .IsRequired()
                    .HasColumnName("end_hour");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.StartHour)
                    .IsRequired()
                    .HasColumnName("start_hour");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.ToTable("topics");

                entity.HasIndex(e => e.Type, "topics_0_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("start_date");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<TrainedCharaTradeItem>(entity =>
            {
                entity.ToTable("trained_chara_trade_item");

                entity.HasIndex(e => e.TrainedCharaRank, "trained_chara_trade_item_0_trained_chara_rank")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.TradeItemCategory).HasColumnName("trade_item_category");

                entity.Property(e => e.TradeItemId).HasColumnName("trade_item_id");

                entity.Property(e => e.TradeItemNum).HasColumnName("trade_item_num");

                entity.Property(e => e.TrainedCharaRank).HasColumnName("trained_chara_rank");
            });

            modelBuilder.Entity<TrainingCuttCharaDatum>(entity =>
            {
                entity.ToTable("training_cutt_chara_data");

                entity.HasIndex(e => new { e.CommandId, e.SubId }, "training_cutt_chara_data_0_command_id_1_sub_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId).HasColumnName("chara_id");

                entity.Property(e => e.CharaNum).HasColumnName("chara_num");

                entity.Property(e => e.CommandId).HasColumnName("command_id");

                entity.Property(e => e.PropTarget).HasColumnName("prop_target");

                entity.Property(e => e.SubId).HasColumnName("sub_id");

                entity.Property(e => e.TargetListIndex).HasColumnName("target_list_index");

                entity.Property(e => e.TargetTimeline).HasColumnName("target_timeline");
            });

            modelBuilder.Entity<TrainingCuttDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("training_cutt_data");

                entity.HasIndex(e => new { e.CommandId, e.SubId }, "training_cutt_data_0_command_id_1_sub_id");

                entity.Property(e => e.CharaNum).HasColumnName("chara_num");

                entity.Property(e => e.CommandId).HasColumnName("command_id");

                entity.Property(e => e.CuttIndex).HasColumnName("cutt_index");

                entity.Property(e => e.SubId).HasColumnName("sub_id");

                entity.Property(e => e.SuccessFlg).HasColumnName("success_flg");

                entity.Property(e => e.TargetCharaIndex).HasColumnName("target_chara_index");

                entity.Property(e => e.TargetValue).HasColumnName("target_value");
            });

            modelBuilder.Entity<TutorialGuideDatum>(entity =>
            {
                entity.ToTable("tutorial_guide_data");

                entity.HasIndex(e => e.GroupId, "tutorial_guide_data_0_group_id");

                entity.HasIndex(e => new { e.GroupId, e.PageIndex }, "tutorial_guide_data_0_group_id_1_page_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.ImageIndex).HasColumnName("image_index");

                entity.Property(e => e.PageIndex).HasColumnName("page_index");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
