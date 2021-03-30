﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SingleModeRouteRace
    {
        public long Id { get; set; }
        public long RaceSetId { get; set; }
        public long TargetType { get; set; }
        public long SortId { get; set; }
        public long Turn { get; set; }
        public long RaceType { get; set; }
        public long ConditionType { get; set; }
        public long ConditionId { get; set; }
        public long ConditionValue1 { get; set; }
        public long ConditionValue2 { get; set; }
        public long DetermineRace { get; set; }
        public long DetermineRaceFlag { get; set; }
    }
}