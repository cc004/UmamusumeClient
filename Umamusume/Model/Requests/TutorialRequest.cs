namespace Umamusume.Model
{

    public sealed class TutorialRequest : RequestBase<TutorialResponse>
    {


        public int? step;




        protected override string Url => "/tutorial/update_step";


        public TutorialRequest()
        {
        }
    }
}
