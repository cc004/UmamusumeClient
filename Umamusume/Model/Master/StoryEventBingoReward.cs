using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class StoryEventBingoReward
    {
        public long Id { get; set; }
        public long RewardSetId { get; set; }
        public long LineNum { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
        public long ItemNum { get; set; }
    }
}
