using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class ItemPack
    {
        public long Id { get; set; }
        public long ItemPackId { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
        public long ItemNum { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
