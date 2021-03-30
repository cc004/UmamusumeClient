using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SingleModeUniqueChara
    {
        public long Id { get; set; }
        public long PartnerId { get; set; }
        public long ScenarioId { get; set; }
        public long CharaId { get; set; }
        public long Period { get; set; }
        public long TrainingPlacement { get; set; }
    }
}
