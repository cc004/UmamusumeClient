using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class CharaMotionAct
    {
        public long Id { get; set; }
        public long CharaId { get; set; }
        public long TargetMotion { get; set; }
        public string CommandName { get; set; }
    }
}
