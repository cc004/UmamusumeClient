using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class StoryEventWinBonu
    {
        public long Id { get; set; }
        public long StoryEventId { get; set; }
        public long MinWinCount { get; set; }
        public long MaxWinCount { get; set; }
        public long BonusPoint { get; set; }
    }
}
