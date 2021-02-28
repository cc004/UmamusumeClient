namespace Umamusume.Model
{

    public sealed class LiveLiveStartRequest : RequestBase<LiveLiveStartResponse>
    {


        public int? music_id;



        public LiveTheaterMemberInfo[] member_info_array;



        public LiveTheaterSettingInfo live_theater_setting_info;



        public int[] live_theater_vocal_chara_id_array;






        public LiveLiveStartRequest()
        {
        }
    }
}
