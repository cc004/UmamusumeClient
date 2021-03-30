using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SingleModeScenario
    {
        public long Id { get; set; }
        public long SortId { get; set; }
        public long ScenarioImageId { get; set; }
        public long PrologueId { get; set; }
        public long TurnSetId { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
