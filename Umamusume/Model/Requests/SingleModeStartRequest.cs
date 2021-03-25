namespace Umamusume.Model
{

    public sealed class SingleModeStartRequest : RequestBase<SingleModeStartResponse>
    {

        protected override string Url => "/single_mode/start";
        public SingleModeStartChara start_chara;
        public TpInfo tp_info;
        public int? current_money;
        public SingleModeStartRequest()
        {
        }
    }
}
