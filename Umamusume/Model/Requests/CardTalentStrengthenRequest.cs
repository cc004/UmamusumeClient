using System;



namespace Umamusume.Model
{

	public sealed class CardTalentStrengthenRequest : RequestBase<CardTalentStrengthenResponse>
	{


		public int? card_id;



		public int? talent_level;



		public int? new_talent_level;



		


		public CardTalentStrengthenRequest()
		{
		}
	}
}
