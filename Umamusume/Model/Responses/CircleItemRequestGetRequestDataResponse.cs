

namespace Umamusume.Model
{

	public sealed class CircleItemRequestGetRequestDataResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public CircleItemRequest[] circle_item_request_array;



			public CircleItemDonate[] circle_item_donate_array;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public CircleItemRequestGetRequestDataResponse()
		{
		}
	}
}
