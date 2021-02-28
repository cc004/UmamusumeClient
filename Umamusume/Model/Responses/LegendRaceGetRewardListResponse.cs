

namespace Umamusume.Model
{

    public sealed class LegendRaceGetRewardListResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public RaceRewardData[] reward_array;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public LegendRaceGetRewardListResponse()
        {
        }
    }
}
