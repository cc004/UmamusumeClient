using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class AnnounceDatum
    {
        public long Id { get; set; }
        public long AnnounceType { get; set; }
        public long AnnounceId { get; set; }
        public long Priority { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
