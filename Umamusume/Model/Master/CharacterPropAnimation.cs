using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class CharacterPropAnimation
    {
        public long Id { get; set; }
        public long PropId { get; set; }
        public long PropAnimId { get; set; }
        public long LayerIndex { get; set; }
        public string UseStateName { get; set; }
        public long SceneType { get; set; }
    }
}
