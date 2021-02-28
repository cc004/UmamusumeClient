namespace Umamusume.Model
{

    public sealed class SupportCardDeckChangeNameRequest : RequestBase<SupportCardDeckChangeNameResponse>
    {


        public int? deck_id;



        public string name;






        public SupportCardDeckChangeNameRequest()
        {
        }
    }
}
