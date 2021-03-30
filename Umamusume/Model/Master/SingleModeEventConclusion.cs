using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SingleModeEventConclusion
    {
        public long Id { get; set; }
        public long CharaId { get; set; }
        public long CharaMotionSetId { get; set; }
    }
}
