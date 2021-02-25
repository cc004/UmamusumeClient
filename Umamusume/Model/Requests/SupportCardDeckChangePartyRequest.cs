using System;



namespace Umamusume.Model
{

	public sealed class SupportCardDeckChangePartyRequest : RequestBase<SupportCardDeckChangePartyResponse>
	{


		public UserSupportCardDeckForUpdateParty[] support_card_deck_array;



		


		public SupportCardDeckChangePartyRequest()
		{
		}
	}
}
