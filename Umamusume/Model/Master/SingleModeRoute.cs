using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SingleModeRoute
    {
        public long Id { get; set; }
        public long ScenarioId { get; set; }
        public long CharaId { get; set; }
        public long RaceSetId { get; set; }
    }
}
