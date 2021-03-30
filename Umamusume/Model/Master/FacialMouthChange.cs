using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class FacialMouthChange
    {
        public long Id { get; set; }
        public long CharaId { get; set; }
        public string BeforeFacialname { get; set; }
        public string AfterFacialname { get; set; }
    }
}
