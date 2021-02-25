

namespace Umamusume.Model
{

	public sealed class ItemExchangeAddFrameResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public UserInfo updated_user_info;



			public UserItem use_item_info;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public ItemExchangeAddFrameResponse()
		{
		}
	}
}
