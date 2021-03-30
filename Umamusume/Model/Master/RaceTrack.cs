using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class RaceTrack
    {
        public long Id { get; set; }
        public long InitialLaneType { get; set; }
        public long EnableHalfGate { get; set; }
        public long HorseNumGateVariation { get; set; }
        public long TurfVisionType { get; set; }
        public long FootsmokeColorType { get; set; }
    }
}
