namespace Umamusume.Model
{

    public sealed class SupportCardStrengthenRequest : RequestBase<SupportCardStrengthenResponse>
    {


        public int? support_card_id;



        public int? use_global_exp;



        public int? current_global_exp;



        public int? use_money;



        public int? current_money;






        public SupportCardStrengthenRequest()
        {
        }
    }
}
