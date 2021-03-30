using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class DailyPack
    {
        public long ShopDataId { get; set; }
        public long PlatformId { get; set; }
        public long Term { get; set; }
        public long RepurchaseDay { get; set; }
        public long GroupId { get; set; }
        public long DailyFreeNum { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
