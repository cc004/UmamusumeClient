using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class FaceTypeDatum
    {
        public string Label { get; set; }
        public string EyebrowL { get; set; }
        public string EyebrowR { get; set; }
        public string EyeL { get; set; }
        public string EyeR { get; set; }
        public string Mouth { get; set; }
        public long MouthShapeType { get; set; }
        public string InverceFaceType { get; set; }
        public long SetFaceGroup { get; set; }
    }
}
