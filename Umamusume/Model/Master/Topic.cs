using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class Topic
    {
        public long Id { get; set; }
        public long Type { get; set; }
        public long Value { get; set; }
        public long Index { get; set; }
        public string StartDate { get; set; }
    }
}
