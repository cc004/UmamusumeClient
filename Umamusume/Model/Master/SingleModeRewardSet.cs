﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SingleModeRewardSet
    {
        public long Id { get; set; }
        public long RewardSetId { get; set; }
        public long OrderMin { get; set; }
        public long OrderMax { get; set; }
        public long RewardType { get; set; }
        public long Bonus { get; set; }
        public long Odds { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
        public long ItemNum { get; set; }
    }
}