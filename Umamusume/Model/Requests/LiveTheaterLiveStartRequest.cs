using System;



namespace Umamusume.Model
{

	public sealed class LiveTheaterLiveStartRequest : RequestBase<LiveTheaterLiveStartResponse>
	{


		public LiveTheaterSaveInfo live_theater_save_info;



		public LiveTheaterSettingInfo live_theater_setting_info;



		public int[] live_theater_vocal_chara_id_array;



		


		public LiveTheaterLiveStartRequest()
		{
		}
	}
}
