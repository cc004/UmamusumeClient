

namespace Umamusume.Model
{

	public sealed class HonorListResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public HonorData[] honor_list;



			public long last_checked_time;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public HonorListResponse()
		{
		}
	}
}
