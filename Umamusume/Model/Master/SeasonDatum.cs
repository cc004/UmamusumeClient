using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SeasonDatum
    {
        public long Id { get; set; }
        public long Type { get; set; }
        public long Season { get; set; }
        public long Priority { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
