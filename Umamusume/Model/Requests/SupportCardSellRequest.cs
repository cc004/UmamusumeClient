using System;



namespace Umamusume.Model
{

	public sealed class SupportCardSellRequest : RequestBase<SupportCardSellResponse>
	{


		public SellSupportCardInfo[] sell_support_card_info_array;



		


		public SupportCardSellRequest()
		{
		}
	}
}
