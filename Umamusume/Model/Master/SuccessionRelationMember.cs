using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SuccessionRelationMember
    {
        public long Id { get; set; }
        public long RelationType { get; set; }
        public long CharaId { get; set; }
    }
}
