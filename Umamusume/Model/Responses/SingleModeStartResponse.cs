

using Newtonsoft.Json;

namespace Umamusume.Model
{

    public sealed class SingleModeStartResponse : ResponseCommon, IMoneyChange
    {

        public class CommonResponse
        {


            public SingleModeChara chara_info;



            public SingleModeRaceCondition[] race_condition_array;



            public SingleModeHomeInfo home_info;



            public SingleModeEventInfo[] unchecked_event_array;



            public TpInfo tp_info;



            public UserItem[] user_item_array;



            public TrainedChara[] add_trained_chara_array;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;


        [JsonIgnore]
        public int current_money => data.user_item_array.CalcMoney();

        public SingleModeStartResponse()
        {
        }
    }
}
