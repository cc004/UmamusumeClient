using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class StoryEventDatum
    {
        public long StoryEventId { get; set; }
        public long NoticeDate { get; set; }
        public long StartDate { get; set; }
        public long MiddleDate01 { get; set; }
        public long MiddleDate02 { get; set; }
        public long EndingDate { get; set; }
        public long EndDate { get; set; }
    }
}
