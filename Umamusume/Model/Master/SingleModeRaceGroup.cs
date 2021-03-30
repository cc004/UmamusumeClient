using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SingleModeRaceGroup
    {
        public long Id { get; set; }
        public long RaceGroupId { get; set; }
        public long RaceProgramId { get; set; }
    }
}
