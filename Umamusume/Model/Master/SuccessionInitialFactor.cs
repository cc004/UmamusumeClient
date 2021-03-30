using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SuccessionInitialFactor
    {
        public long Id { get; set; }
        public long FactorType { get; set; }
        public long Value1 { get; set; }
        public long Value2 { get; set; }
        public long AddPoint { get; set; }
    }
}
