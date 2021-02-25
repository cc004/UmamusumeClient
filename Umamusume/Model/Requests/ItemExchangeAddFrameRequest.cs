using System;



namespace Umamusume.Model
{

	public sealed class ItemExchangeAddFrameRequest : RequestBase<ItemExchangeAddFrameResponse>
	{


		public int? exchange_id;



		public int? count;



		public int? current_num;



		


		public ItemExchangeAddFrameRequest()
		{
		}
	}
}
