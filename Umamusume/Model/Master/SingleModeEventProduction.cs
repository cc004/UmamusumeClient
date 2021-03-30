using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class SingleModeEventProduction
    {
        public long StoryId { get; set; }
        public long EventCategoryId { get; set; }
        public long MaxItemId { get; set; }
    }
}
