﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class RaceJikkyoComment
    {
        public long Id { get; set; }
        public long GroupId { get; set; }
        public string Message { get; set; }
        public string Voice { get; set; }
        public long Per { get; set; }
        public long MessageGroup { get; set; }
    }
}