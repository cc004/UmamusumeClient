namespace Umamusume.Model
{

    public sealed class GachaExecRequest : RequestBase<GachaExecResponse>
    {


        public int gacha_id;



        public int draw_type;



        public int draw_num;



        public int current_num;



        public int item_id;


        protected override string Url => "/gacha/exec";



        public GachaExecRequest()
        {
        }
    }
}
