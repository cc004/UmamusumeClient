using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class MiniBg
    {
        public long Id { get; set; }
        public long SceneType { get; set; }
        public long ReleaseNum { get; set; }
        public long SizeX { get; set; }
        public long SizeY { get; set; }
        public string GridOffsetX { get; set; }
        public string GridOffsetY { get; set; }
        public long DressId { get; set; }
        public string Position { get; set; }
    }
}
