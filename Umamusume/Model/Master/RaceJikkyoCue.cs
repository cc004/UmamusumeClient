using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class RaceJikkyoCue
    {
        public long Id { get; set; }
        public long CuesheetId { get; set; }
        public long CuesheetType { get; set; }
    }
}
