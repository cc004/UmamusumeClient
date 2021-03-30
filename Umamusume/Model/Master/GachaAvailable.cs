using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class GachaAvailable
    {
        public long GachaId { get; set; }
        public long CardId { get; set; }
        public long CardType { get; set; }
        public long Rarity { get; set; }
        public long Odds { get; set; }
        public long IsPickup { get; set; }
        public long RecommendOrder { get; set; }
        public long IsPrizeSelectable { get; set; }
    }
}
