using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class RaceEnvDefine
    {
        public long Id { get; set; }
        public long RaceTrackId { get; set; }
        public long Season { get; set; }
        public long Weather { get; set; }
        public long Timezone { get; set; }
        public long Resource { get; set; }
    }
}
