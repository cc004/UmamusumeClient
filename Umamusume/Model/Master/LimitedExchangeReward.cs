using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class LimitedExchangeReward
    {
        public long Id { get; set; }
        public long GroupId { get; set; }
        public long Odds { get; set; }
        public long ItemExchangeId { get; set; }
        public long RibbonValue { get; set; }
    }
}
