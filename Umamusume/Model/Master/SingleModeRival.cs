using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SingleModeRival
    {
        public long Id { get; set; }
        public long CharaId { get; set; }
        public long Turn { get; set; }
        public long RaceProgramId { get; set; }
        public long ConditionType { get; set; }
        public long RivalCharaId { get; set; }
        public long SingleModeNpcId { get; set; }
    }
}
