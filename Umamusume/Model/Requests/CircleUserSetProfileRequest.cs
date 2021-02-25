using System;



namespace Umamusume.Model
{

	public sealed class CircleUserSetProfileRequest : RequestBase<CircleUserSetProfileResponse>
	{


		public int? chara_id;



		public int? bg_id;



		public string recruit_comment;



		public int? dress_id;



		


		public CircleUserSetProfileRequest()
		{
		}
	}
}
