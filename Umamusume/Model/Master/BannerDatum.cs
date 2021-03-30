using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class BannerDatum
    {
        public long Id { get; set; }
        public long BannerId { get; set; }
        public long Type { get; set; }
        public long GroupId { get; set; }
        public long Transition { get; set; }
        public long Priority { get; set; }
        public long ConditionValue { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
