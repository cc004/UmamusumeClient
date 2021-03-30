using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SupportCardLevel
    {
        public long Id { get; set; }
        public long Rarity { get; set; }
        public long Level { get; set; }
        public long TotalExp { get; set; }
    }
}
