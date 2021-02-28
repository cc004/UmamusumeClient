namespace Umamusume.Model
{

    public sealed class GachaLoadRequest : RequestBase<GachaLoadResponse>
    {


        protected override string Url => "/gacha/index";


        public GachaLoadRequest()
        {
        }
    }
}
