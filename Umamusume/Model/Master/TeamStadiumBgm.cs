using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class TeamStadiumBgm
    {
        public long Id { get; set; }
        public long SceneType { get; set; }
        public long Priority { get; set; }
        public string CueName { get; set; }
        public string CuesheetName { get; set; }
    }
}
