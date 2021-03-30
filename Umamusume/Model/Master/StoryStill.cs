using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class StoryStill
    {
        public long Id { get; set; }
        public long StillId { get; set; }
        public long PageId { get; set; }
        public long OrderId { get; set; }
    }
}
