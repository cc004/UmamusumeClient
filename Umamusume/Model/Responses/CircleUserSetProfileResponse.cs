

namespace Umamusume.Model
{

	public sealed class CircleUserSetProfileResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public CircleInfo circle_info;



			public CircleRanking circle_ranking_last_month;



			public int? chara_id;



			public int? bg_id;



			public string recruit_comment;



			public int? dress_id;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public CircleUserSetProfileResponse()
		{
		}
	}
}
