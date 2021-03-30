using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class AnnounceSupportCard
    {
        public long Id { get; set; }
        public long CutsPattern { get; set; }
        public long SupportCardIdA { get; set; }
        public long SupportCardIdB { get; set; }
        public long SupportCardIdC { get; set; }
    }
}
