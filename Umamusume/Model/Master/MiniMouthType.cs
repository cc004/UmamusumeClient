using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class MiniMouthType
    {
        public long Id { get; set; }
        public long Type { get; set; }
        public long ReverseMouthId { get; set; }
    }
}
