﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class RandomEarTailMotion
    {
        public long Id { get; set; }
        public long PartsType { get; set; }
        public string MotionName { get; set; }
        public long EarType { get; set; }
        public long UseStory { get; set; }
    }
}