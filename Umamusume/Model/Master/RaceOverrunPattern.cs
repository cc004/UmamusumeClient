using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class RaceOverrunPattern
    {
        public long Id { get; set; }
        public long FinishOrder0Type { get; set; }
        public long FinishOrder1Type { get; set; }
        public long FinishOrder2Type { get; set; }
        public long FinishOrder3Type { get; set; }
        public long FinishOrder4Type { get; set; }
        public long FinishOrderLoseType { get; set; }
    }
}
