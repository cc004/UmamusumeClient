﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class RaceCourseSet
    {
        public long Id { get; set; }
        public long RaceTrackId { get; set; }
        public long Distance { get; set; }
        public long Ground { get; set; }
        public long Inout { get; set; }
        public long Turn { get; set; }
        public long FenceSet { get; set; }
        public long FloatLaneMax { get; set; }
        public long CourseSetStatusId { get; set; }
        public long FinishTimeMin { get; set; }
        public long FinishTimeMinRandomRange { get; set; }
        public long FinishTimeMax { get; set; }
        public long FinishTimeMaxRandomRange { get; set; }
    }
}