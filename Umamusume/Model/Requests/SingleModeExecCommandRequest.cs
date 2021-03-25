namespace Umamusume.Model
{

    public sealed class SingleModeExecCommandRequest : RequestBase<SingleModeExecCommandResponse>
    {
        protected override string Url => "/single_mode/exec_command";

        public int? command_type;



        public int? command_id;



        public int? command_group_id;



        public int? select_id;






        public SingleModeExecCommandRequest()
        {
        }
    }
}
