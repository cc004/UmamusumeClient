

namespace Umamusume.Model
{

	public sealed class CardRarityUpgradeResponse : ResponseCommon
	{

		public class CommonResponse
		{


			public UserCard card_data;



			public PieceData[] piece_data;



			public CommonResponse()
			{
			}
		}



		public CommonResponse data;



		public CardRarityUpgradeResponse()
		{
		}
	}
}
