using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class AvailableSkillSet
    {
        public long Id { get; set; }
        public long AvailableSkillSetId { get; set; }
        public long SkillId { get; set; }
        public long NeedRank { get; set; }
    }
}
