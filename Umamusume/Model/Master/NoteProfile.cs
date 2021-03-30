using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class NoteProfile
    {
        public long Id { get; set; }
        public long CharaId { get; set; }
        public long TextType { get; set; }
        public long LockType { get; set; }
        public long LockValue { get; set; }
        public long Sort { get; set; }
    }
}
