

namespace Umamusume.Model
{

    public sealed class ItemShowExchangeResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public ItemExchangeLimit[] limit_list;



            public int[] disabled_id_array;



            public int[] release_id_array;



            public LimitedShopInfo limited_shop_info;



            public LimitedGoodsInfo[] limited_goods_info_array;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public ItemShowExchangeResponse()
        {
        }
    }
}
