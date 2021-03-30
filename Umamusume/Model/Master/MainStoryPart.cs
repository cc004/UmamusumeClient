using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class MainStoryPart
    {
        public long Id { get; set; }
        public long MainStoryLastChapter { get; set; }
        public long StartDate { get; set; }
        public string UiColor { get; set; }
    }
}
