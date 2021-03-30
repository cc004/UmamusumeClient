using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class GachaExchange
    {
        public long GachaId { get; set; }
        public long CardId { get; set; }
        public long CardType { get; set; }
        public long PayItemNum { get; set; }
    }
}
