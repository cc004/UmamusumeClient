using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SingleModeCharaEffect
    {
        public long Id { get; set; }
        public long EffectType { get; set; }
        public long EffectCategory { get; set; }
        public long EffectGroupId { get; set; }
        public long Priority { get; set; }
    }
}
