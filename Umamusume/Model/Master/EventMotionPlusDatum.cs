using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class EventMotionPlusDatum
    {
        public long Id { get; set; }
        public string CommandName { get; set; }
        public string BaseStateName { get; set; }
        public long LayerIndex { get; set; }
        public long TailMotionType { get; set; }
        public long StartBlendTime { get; set; }
        public long EndBlendTime { get; set; }
    }
}
