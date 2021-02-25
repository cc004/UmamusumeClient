

namespace Umamusume.Model
{

	public sealed class GachaLoadResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public GachaInfoList[] gacha_info_list;



			public GachaLimitInfo limit_item_info;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public GachaLoadResponse()
		{
		}
	}
}
