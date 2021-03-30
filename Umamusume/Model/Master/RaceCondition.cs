using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class RaceCondition
    {
        public long Id { get; set; }
        public long Season { get; set; }
        public long Weather { get; set; }
        public long Ground { get; set; }
        public long Rate { get; set; }
    }
}
