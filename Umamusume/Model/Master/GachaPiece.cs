using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class GachaPiece
    {
        public long Id { get; set; }
        public long Rarity { get; set; }
        public long PieceType { get; set; }
        public long PieceNum { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
    }
}
