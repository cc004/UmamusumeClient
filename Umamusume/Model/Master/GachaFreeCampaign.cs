using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class GachaFreeCampaign
    {
        public long Id { get; set; }
        public long GachaId { get; set; }
        public long TargetDrawType { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
