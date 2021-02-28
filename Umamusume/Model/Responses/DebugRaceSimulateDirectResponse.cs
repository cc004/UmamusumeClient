

namespace Umamusume.Model
{

    public sealed class DebugRaceSimulateDirectResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public string race_scenario;



            public RaceSimulateResult[] result_array;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public DebugRaceSimulateDirectResponse()
        {
        }
    }
}
