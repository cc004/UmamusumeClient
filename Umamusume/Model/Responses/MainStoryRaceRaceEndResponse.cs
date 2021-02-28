

namespace Umamusume.Model
{

    public sealed class MainStoryRaceRaceEndResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public MainStoryData[] main_story_data_list;



            public DisplayRewardInfo[] reward_array;



            public RewardSummaryInfo reward_summary_info;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public MainStoryRaceRaceEndResponse()
        {
        }
    }
}
