using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class CircleRankDatum
    {
        public long Id { get; set; }
        public long NeedRankingMax { get; set; }
        public long NeedRankingMin { get; set; }
        public long RewardItemCategory1 { get; set; }
        public long RewardItemId1 { get; set; }
        public long RewardNum1 { get; set; }
        public long RewardItemCategory2 { get; set; }
        public long RewardItemId2 { get; set; }
        public long RewardNum2 { get; set; }
    }
}
