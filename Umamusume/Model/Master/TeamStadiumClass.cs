using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class TeamStadiumClass
    {
        public long Id { get; set; }
        public long TeamStadiumId { get; set; }
        public long TeamClass { get; set; }
        public long UnitMaxNum { get; set; }
        public long ClassUpRange { get; set; }
        public long ClassDownRange { get; set; }
    }
}
