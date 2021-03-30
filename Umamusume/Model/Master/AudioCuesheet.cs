using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class AudioCuesheet
    {
        public long Id { get; set; }
        public string CueSheet { get; set; }
        public long Attribute { get; set; }
    }
}
