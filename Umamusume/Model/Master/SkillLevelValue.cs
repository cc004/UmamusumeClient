using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SkillLevelValue
    {
        public long Id { get; set; }
        public long AbilityType { get; set; }
        public long Level { get; set; }
        public long FloatAbilityValueCoef { get; set; }
    }
}
