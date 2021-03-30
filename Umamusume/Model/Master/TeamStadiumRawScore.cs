﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class TeamStadiumRawScore
    {
        public long Id { get; set; }
        public long Priority { get; set; }
        public long ConditionType { get; set; }
        public long ConditionValue1 { get; set; }
        public long ConditionValue2 { get; set; }
        public long Score { get; set; }
        public long RaceScoreNameId { get; set; }
        public long SortOrder { get; set; }
    }
}