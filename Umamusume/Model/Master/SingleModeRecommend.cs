using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SingleModeRecommend
    {
        public long Id { get; set; }
        public long GradeUpperLimit { get; set; }
        public long GradeLowerLimit { get; set; }
    }
}
