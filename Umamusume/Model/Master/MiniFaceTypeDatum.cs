using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class MiniFaceTypeDatum
    {
        public string Label { get; set; }
        public long EyebrowL { get; set; }
        public long EyebrowR { get; set; }
        public long EyeL { get; set; }
        public long EyeR { get; set; }
        public long Mouth { get; set; }
        public long Cheek { get; set; }
    }
}
