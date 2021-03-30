using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SingleModeEvaluation
    {
        public long Id { get; set; }
        public long Evaluation { get; set; }
        public long CharaId { get; set; }
    }
}
