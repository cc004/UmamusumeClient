using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class TextDatum
    {
        public long Id { get; set; }
        public long Category { get; set; }
        public long Index { get; set; }
        public string Text { get; set; }
    }
}
