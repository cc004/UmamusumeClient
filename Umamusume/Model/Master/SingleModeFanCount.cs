using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SingleModeFanCount
    {
        public long Id { get; set; }
        public long FanSetId { get; set; }
        public long Order { get; set; }
        public long FanCount { get; set; }
    }
}
