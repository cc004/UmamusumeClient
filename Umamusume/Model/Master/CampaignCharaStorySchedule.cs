using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class CampaignCharaStorySchedule
    {
        public long CampaignId { get; set; }
        public long CharaId { get; set; }
        public long StoryId { get; set; }
    }
}
