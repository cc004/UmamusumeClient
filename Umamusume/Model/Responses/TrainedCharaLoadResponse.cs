

namespace Umamusume.Model
{

    public sealed class TrainedCharaLoadResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public TrainedChara[] trained_chara_array;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public TrainedCharaLoadResponse()
        {
        }
    }
}
