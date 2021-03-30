using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SkillExp
    {
        public long Id { get; set; }
        public long Type { get; set; }
        public long Level { get; set; }
        public long Scale { get; set; }
    }
}
