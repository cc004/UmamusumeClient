

namespace Umamusume.Model
{

    public sealed class MainStoryRaceGetEntryListResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public MainStoryRaceEntryChara[] entry_chara_array;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public MainStoryRaceGetEntryListResponse()
        {
        }
    }
}
