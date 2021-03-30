using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class PieceDatum
    {
        public long Id { get; set; }
        public long ItemPlaceId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
