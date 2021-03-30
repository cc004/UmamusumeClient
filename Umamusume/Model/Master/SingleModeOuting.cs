using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SingleModeOuting
    {
        public long Id { get; set; }
        public long CommandGroupId { get; set; }
        public long Condition { get; set; }
        public long IsPlayCutt { get; set; }
    }
}
