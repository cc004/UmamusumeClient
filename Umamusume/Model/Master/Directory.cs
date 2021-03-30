using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class Directory
    {
        public long Id { get; set; }
        public long RequiredPoint { get; set; }
        public long RankLevel { get; set; }
        public long ItemCategory1 { get; set; }
        public long ItemId1 { get; set; }
        public long ItemNum1 { get; set; }
    }
}
