﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class DailyRaceBilling
    {
        public long Id { get; set; }
        public long Frequency { get; set; }
        public long PayCost { get; set; }
    }
}