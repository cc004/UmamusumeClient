using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class TeamStadiumScoreBonu
    {
        public long Id { get; set; }
        public long Priority { get; set; }
        public long ConditionType { get; set; }
        public long ConditionValue1 { get; set; }
        public long ConditionValue2 { get; set; }
        public long ScoreRate { get; set; }
    }
}
