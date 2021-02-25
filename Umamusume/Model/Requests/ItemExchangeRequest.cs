using System;



namespace Umamusume.Model
{

	public sealed class ItemExchangeRequest : RequestBase<ItemExchangeResponse>
	{


		public int? exchange_id;



		public int? count;



		public int? current_num;



		


		public ItemExchangeRequest()
		{
		}
	}
}
