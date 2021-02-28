

namespace Umamusume.Model
{

    public sealed class CircleMakeResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public CircleInfo circle_info;



            public CircleUser circle_user;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public CircleMakeResponse()
        {
        }
    }
}
