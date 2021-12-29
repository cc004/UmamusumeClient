namespace Umamusume.Model
{
    public sealed class PreSingleModeIndexRequest : RequestBase<PreSingleModeIndexResponse>
    {
        protected override string Url => "/pre_single_mode/index";

        public PreSingleModeIndexRequest()
        {
        }
    }
}