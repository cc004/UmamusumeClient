using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SingleModeAnalyzeMessage
    {
        public long Id { get; set; }
        public long ProperGround { get; set; }
        public long ProperDistance { get; set; }
        public long Popularity { get; set; }
        public long Year { get; set; }
        public long Priority { get; set; }
        public long Rate { get; set; }
        public long MotionType { get; set; }
        public long CharacterType { get; set; }
    }
}
