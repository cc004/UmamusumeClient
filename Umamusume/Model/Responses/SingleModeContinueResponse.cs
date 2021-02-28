

namespace Umamusume.Model
{

    public sealed class SingleModeContinueResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public SingleModeChara chara_info;



            public SingleModeHomeInfo home_info;



            public SingleRaceStartInfo race_start_info;



            public SingleModeEventInfo[] unchecked_event_array;



            public UserItem user_item;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public SingleModeContinueResponse()
        {
        }
    }
}
