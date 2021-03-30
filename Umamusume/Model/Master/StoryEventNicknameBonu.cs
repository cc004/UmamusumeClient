using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class StoryEventNicknameBonu
    {
        public long Id { get; set; }
        public long StoryEventId { get; set; }
        public long NicknameRank { get; set; }
        public long BonusPoint { get; set; }
    }
}
