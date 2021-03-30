using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class RaceTrophy
    {
        public long Id { get; set; }
        public long TrophyId { get; set; }
        public long RaceInstanceId { get; set; }
        public long OriginalFlag { get; set; }
        public long DispOrder { get; set; }
        public long Size { get; set; }
        public long EventType { get; set; }
        public string StartDate { get; set; }
        public string DisplayEndDate { get; set; }
    }
}
