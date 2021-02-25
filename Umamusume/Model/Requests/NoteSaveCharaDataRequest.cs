using System;



namespace Umamusume.Model
{

	public sealed class NoteSaveCharaDataRequest : RequestBase<NoteSaveCharaDataResponse>
	{


		public int? chara_id;



		public int? dress_id;



		public int? mini_dress_id;



		public int? is_read_profile;



		


		public NoteSaveCharaDataRequest()
		{
		}
	}
}
