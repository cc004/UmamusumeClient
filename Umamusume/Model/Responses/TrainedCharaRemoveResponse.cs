

namespace Umamusume.Model
{

    public sealed class TrainedCharaRemoveResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public TrainedChara[] trained_chara_array;



            public RewardSummaryInfo reward_summary_info;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public TrainedCharaRemoveResponse()
        {
        }
    }
}
