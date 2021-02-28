

namespace Umamusume.Model
{

    public sealed class LiveTheaterIndexResponse : ResponseCommon
    {

        public class CommonResponse
        {


            public LiveTheaterSaveInfo[] live_theater_save_info_array;



            public long live_theater_last_checked_time;



            public CommonResponse()
            {
            }
        }



        public CommonResponse data;



        public LiveTheaterIndexResponse()
        {
        }
    }
}
