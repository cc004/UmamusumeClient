namespace Umamusume.Model
{

    public sealed class DataLinkGetByTransitionCodeRequest : RequestBase<DataLinkGetByTransitionCodeResponse>
    {


        public string password;



        public string input_viewer_id;


        protected override string Url => "/account/get_by_transition_code";



        public DataLinkGetByTransitionCodeRequest()
        {
        }
    }
}
