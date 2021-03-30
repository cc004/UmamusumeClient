using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class LoginBonusDatum
    {
        public long Id { get; set; }
        public long Type { get; set; }
        public long CountNum { get; set; }
        public long DispOrder { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
