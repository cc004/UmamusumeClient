using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SingleModeTagCardPo
    {
        public long Id { get; set; }
        public long SupportCardId { get; set; }
        public long Pattern { get; set; }
        public long PosIndex { get; set; }
        public long PosX { get; set; }
        public long PosY { get; set; }
        public long ScaleX { get; set; }
        public long ScaleY { get; set; }
        public long RotZ { get; set; }
    }
}
