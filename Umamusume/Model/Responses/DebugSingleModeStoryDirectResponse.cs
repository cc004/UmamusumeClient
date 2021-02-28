

namespace Umamusume.Model
{

    public sealed class DebugSingleModeStoryDirectResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public StoryDirectEventReward[] event_gain;



            public StoryDirectSkillSet[] skill_set;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public DebugSingleModeStoryDirectResponse()
        {
        }
    }
}
