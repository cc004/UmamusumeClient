using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class TutorialGuideDatum
    {
        public long Id { get; set; }
        public long GroupId { get; set; }
        public long PageIndex { get; set; }
        public long ImageIndex { get; set; }
    }
}
