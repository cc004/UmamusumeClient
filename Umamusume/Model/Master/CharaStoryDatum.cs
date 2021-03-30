﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class CharaStoryDatum
    {
        public long Id { get; set; }
        public long CharaId { get; set; }
        public long EpisodeIndex { get; set; }
        public long StoryId { get; set; }
        public long LockType1 { get; set; }
        public long LockValue11 { get; set; }
        public long LockValue12 { get; set; }
        public long AddRewardCategory1 { get; set; }
        public long AddRewardId1 { get; set; }
        public long AddRewardNum1 { get; set; }
        public long ExpType { get; set; }
    }
}