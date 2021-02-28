namespace Umamusume.Model
{

    public sealed class GachaSelectPrizeRequest : RequestBase<GachaSelectPrizeResponse>
    {


        public int? gacha_id;



        public int? card_type;



        public int? card_id;






        public GachaSelectPrizeRequest()
        {
        }
    }
}
