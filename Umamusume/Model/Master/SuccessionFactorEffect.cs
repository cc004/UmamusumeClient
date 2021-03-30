using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SuccessionFactorEffect
    {
        public long Id { get; set; }
        public long FactorGroupId { get; set; }
        public long EffectId { get; set; }
        public long TargetType { get; set; }
        public long Value1 { get; set; }
        public long Value2 { get; set; }
    }
}
