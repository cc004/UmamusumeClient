namespace Umamusume.Model
{

    public sealed class TutorialSkipRequest : RequestBase<TutorialSkipResponse>
    {


        protected override string Url => "/tutorial/skip";


        public TutorialSkipRequest()
        {
        }
    }
}
