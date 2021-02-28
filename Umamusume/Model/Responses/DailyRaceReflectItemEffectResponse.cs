

namespace Umamusume.Model
{

    public sealed class DailyRaceReflectItemEffectResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public int? weather;



            public int? ground_condition;



            public RaceHorseData[] race_horse_data_array;



            public UserItem[] item_info_array;



            public int? state;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public DailyRaceReflectItemEffectResponse()
        {
        }
    }
}
