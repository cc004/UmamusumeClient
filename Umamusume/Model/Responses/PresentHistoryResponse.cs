

namespace Umamusume.Model
{

    public sealed class PresentHistoryResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public PresentData[] present_array;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public PresentHistoryResponse()
        {
        }
    }
}
