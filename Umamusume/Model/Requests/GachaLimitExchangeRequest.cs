using System;



namespace Umamusume.Model
{

	public sealed class GachaLimitExchangeRequest : RequestBase<GachaLimitExchangeResponse>
	{


		public int? gacha_id;



		public int? card_type;



		public int? card_id;



		public int? current_num;



		


		public GachaLimitExchangeRequest()
		{
		}
	}
}
