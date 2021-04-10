namespace Umamusume.Model
{

    public sealed class DataLinkChainByTransitionCodeRequest : RequestBase<DataLinkChainByTransitionCodeResponse>
    {


        public string password;



        public int input_viewer_id;




        protected override string Url => "/account/chain_by_transition_code";


        public DataLinkChainByTransitionCodeRequest()
        {
        }
    }
}
