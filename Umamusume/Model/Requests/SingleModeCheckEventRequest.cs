namespace Umamusume.Model
{

    public sealed class SingleModeCheckEventRequest : RequestBase<SingleModeCheckEventResponse>
    {
        protected override string Url => "/single_mode/check_event";

        public int? event_id;



        public int? chara_id;



        public int? choice_number;


        public int? current_turn;



        public SingleModeCheckEventRequest()
        {
        }
    }
}
