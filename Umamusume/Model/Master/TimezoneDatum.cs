using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class TimezoneDatum
    {
        public long Timezone { get; set; }
        public long Priority { get; set; }
        public string StartHour { get; set; }
        public string EndHour { get; set; }
    }
}
