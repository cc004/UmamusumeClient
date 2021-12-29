namespace Umamusume.Model
{

    public sealed class GachaLimitExchangeRequest : RequestBase<GachaLimitExchangeResponse>
    {


        public int? gacha_id;



        public int? card_type;



        public int? card_id;



        public int? current_num;


        protected override string Url => "/gacha/limit_exchange";


        public GachaLimitExchangeRequest()
        {
        }
    }
}
