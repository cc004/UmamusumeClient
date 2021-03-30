using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class TrainedCharaTradeItem
    {
        public long Id { get; set; }
        public long TrainedCharaRank { get; set; }
        public long TradeItemCategory { get; set; }
        public long TradeItemId { get; set; }
        public long TradeItemNum { get; set; }
    }
}
