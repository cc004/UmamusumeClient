using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class LoginBonusDetail
    {
        public long Id { get; set; }
        public long LoginBonusId { get; set; }
        public long Count { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
        public long ItemNum { get; set; }
    }
}
