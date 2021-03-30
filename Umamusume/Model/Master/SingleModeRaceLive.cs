using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SingleModeRaceLive
    {
        public long Id { get; set; }
        public long Grade { get; set; }
        public long RaceInstanceId { get; set; }
        public long MusicId { get; set; }
    }
}
