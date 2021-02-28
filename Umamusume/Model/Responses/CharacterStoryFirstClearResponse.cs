

namespace Umamusume.Model
{

    public sealed class CharacterStoryFirstClearResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public CharacterStoryData character_story_data;



            public DisplayRewardInfo[] reward_array;



            public RewardSummaryInfo reward_summary_info;



            public int? release_item_flag;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public CharacterStoryFirstClearResponse()
        {
        }
    }
}
