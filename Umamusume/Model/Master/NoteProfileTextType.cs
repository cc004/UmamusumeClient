using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class NoteProfileTextType
    {
        public long Id { get; set; }
        public long TextType { get; set; }
        public long TextCategoryId { get; set; }
        public long Sort { get; set; }
    }
}
