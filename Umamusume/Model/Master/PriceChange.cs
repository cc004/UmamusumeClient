using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class PriceChange
    {
        public long Id { get; set; }
        public long GroupId { get; set; }
        public long MinNum { get; set; }
        public long MaxNum { get; set; }
        public long PayItemNum { get; set; }
    }
}
