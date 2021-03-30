﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class TeamStadiumRank
    {
        public long Id { get; set; }
        public long TeamRank { get; set; }
        public long TeamRankGroup { get; set; }
        public long TeamMinValue { get; set; }
        public long TeamMaxValue { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
        public long ItemNum { get; set; }
    }
}
