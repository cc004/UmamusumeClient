namespace Umamusume.Model
{

    public sealed class SingleModeFinishRequest : RequestBase<SingleModeFinishResponse>
    {
        protected override string Url => "/single_mode/finish";

        public bool is_force_delete;

        public int? current_turn;




        public SingleModeFinishRequest()
        {
        }
    }
}
