using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class HomeWalkGroup
    {
        public long Id { get; set; }
        public long CharaId1 { get; set; }
        public long CharaId2 { get; set; }
        public long CharaId3 { get; set; }
    }
}
