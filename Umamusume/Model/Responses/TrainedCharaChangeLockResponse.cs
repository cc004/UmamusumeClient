

namespace Umamusume.Model
{

    public sealed class TrainedCharaChangeLockResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public int? trained_chara_id;



            public int? is_locked;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public TrainedCharaChangeLockResponse()
        {
        }
    }
}
