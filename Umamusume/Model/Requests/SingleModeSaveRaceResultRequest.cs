namespace Umamusume.Model
{

    public sealed class SingleModeSaveRaceResultRequest : RequestBase<SingleModeSaveRaceResultResponse>
    {


        public SingleModeRaceResult race_result;



        public string race_scenario;



        public int? auto_continue_num;



        public int? random_seed;






        public SingleModeSaveRaceResultRequest()
        {
        }
    }
}
