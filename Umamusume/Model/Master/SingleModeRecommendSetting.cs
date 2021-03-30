using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SingleModeRecommendSetting
    {
        public long Id { get; set; }
        public long RecommendCourseId { get; set; }
        public string HeaderFontColor { get; set; }
    }
}
