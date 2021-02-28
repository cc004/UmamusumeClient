

namespace Umamusume.Model
{

    public sealed class CardGetCardEventSkillResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public EventSkill[] event_skill_list;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public CardGetCardEventSkillResponse()
        {
        }
    }
}
