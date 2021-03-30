using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SingleModeSkillNeedPoint
    {
        public long Id { get; set; }
        public long NeedSkillPoint { get; set; }
        public long StatusType { get; set; }
        public long StatusValue { get; set; }
    }
}
