using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class StoryEventStoryDatum
    {
        public long Id { get; set; }
        public long StoryEventId { get; set; }
        public long EpisodeIndexId { get; set; }
        public long StoryConditionType { get; set; }
        public long StoryId1 { get; set; }
        public long NeedPoint { get; set; }
        public long AddRewardCategory1 { get; set; }
        public long AddRewardId1 { get; set; }
        public long AddRewardNum1 { get; set; }
        public long StartDate { get; set; }
    }
}
