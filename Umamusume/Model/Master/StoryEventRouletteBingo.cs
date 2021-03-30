﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class StoryEventRouletteBingo
    {
        public long Id { get; set; }
        public long RouletteId { get; set; }
        public long StoryEventId { get; set; }
        public long SheetNum { get; set; }
        public long CanLoop { get; set; }
        public long UseItemCategory { get; set; }
        public long UseItemId { get; set; }
        public long UseItemNum { get; set; }
        public long CharacterId { get; set; }
        public long DressId { get; set; }
        public long ResetLine { get; set; }
        public long RewardSetId { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}