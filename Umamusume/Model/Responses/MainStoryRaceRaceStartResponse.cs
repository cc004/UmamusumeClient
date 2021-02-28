

namespace Umamusume.Model
{

    public sealed class MainStoryRaceRaceStartResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public int? random_seed;



            public RaceHorseData[] race_horse_data;



            public int? running_style;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public MainStoryRaceRaceStartResponse()
        {
        }
    }
}
