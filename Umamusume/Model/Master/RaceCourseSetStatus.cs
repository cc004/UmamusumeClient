using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class RaceCourseSetStatus
    {
        public long CourseSetStatusId { get; set; }
        public long TargetStatus1 { get; set; }
        public long TargetStatus2 { get; set; }
    }
}
