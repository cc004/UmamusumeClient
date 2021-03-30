using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class RaceJikkyoTrigger
    {
        public long Id { get; set; }
        public long Command { get; set; }
        public long Inequality { get; set; }
        public long Horse1 { get; set; }
        public long Horse2 { get; set; }
        public long Param1 { get; set; }
        public long Param2 { get; set; }
    }
}
