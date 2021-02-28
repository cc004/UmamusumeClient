namespace Umamusume.Model
{

    public sealed class CardSellPieceRequest : RequestBase<CardSellPieceResponse>
    {


        public PieceData[] sell_piece_data_array;






        public CardSellPieceRequest()
        {
        }
    }
}
