﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class EventMotionDatum
    {
        public long Id { get; set; }
        public string CommandName { get; set; }
        public string BaseStateName { get; set; }
        public long PoseBlend { get; set; }
        public long Type { get; set; }
        public long StateGroup { get; set; }
        public long Category { get; set; }
        public long StartBlendTime { get; set; }
        public long EndBlendTime { get; set; }
    }
}