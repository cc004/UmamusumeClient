

namespace Umamusume.Model
{

    public sealed class MainStoryRaceGetRaceTableResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public RaceHorseData[] race_horse_data;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public MainStoryRaceGetRaceTableResponse()
        {
        }
    }
}
