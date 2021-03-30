using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class RacePlayerCamera
    {
        public long Id { get; set; }
        public long Priority { get; set; }
        public string PrefabName { get; set; }
        public long Category { get; set; }
    }
}
