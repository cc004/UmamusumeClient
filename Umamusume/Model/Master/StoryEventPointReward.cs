using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class StoryEventPointReward
    {
        public long Id { get; set; }
        public long StoryEventId { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
        public long ItemNum { get; set; }
        public long Point { get; set; }
    }
}
