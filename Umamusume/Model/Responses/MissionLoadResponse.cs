

namespace Umamusume.Model
{

    public sealed class MissionLoadResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public UserMission[] mission_list;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public MissionLoadResponse()
        {
        }
    }
}
