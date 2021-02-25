using System;



namespace Umamusume.Model
{

	public sealed class CardRarityUpgradeRequest : RequestBase<CardRarityUpgradeResponse>
	{


		public int? card_id;



		public int? new_rarity;



		public int? now_rarity;



		


		public CardRarityUpgradeRequest()
		{
		}
	}
}
