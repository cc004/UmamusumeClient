

namespace Umamusume.Model
{

    public sealed class MainStoryFirstClearResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public MainStoryData main_story_data;



            public DisplayRewardInfo[] reward_array;



            public RewardSummaryInfo reward_summary_info;



            public UserMusic[] add_music_array;



            public int? release_item_flag;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public MainStoryFirstClearResponse()
        {
        }
    }
}
