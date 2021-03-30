using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class HomeStoryTrigger
    {
        public long Id { get; set; }
        public long PosId { get; set; }
        public long HomeEventType { get; set; }
        public long Num { get; set; }
        public long StoryId { get; set; }
        public long CharaId1 { get; set; }
        public long CharaId2 { get; set; }
        public long CharaId3 { get; set; }
        public long ConditionType { get; set; }
    }
}
