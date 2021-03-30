﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Umamusume.Model.Master
{
    public partial class MobDatum
    {
        public long MobId { get; set; }
        public long CharaFaceModel { get; set; }
        public long CharaSkinColor { get; set; }
        public long CharaHairModel { get; set; }
        public long CharaHairColor { get; set; }
        public long CharaHeight { get; set; }
        public long CharaBustSize { get; set; }
        public long Socks { get; set; }
        public long DefaultPersonality { get; set; }
        public long RacePersonality { get; set; }
        public long RaceRunningType { get; set; }
        public long Sex { get; set; }
        public long DressId { get; set; }
        public long DressColorId { get; set; }
        public long UseLive { get; set; }
        public long HairCutoff { get; set; }
        public long AttachmentModelId { get; set; }
        public long CaptureType { get; set; }
    }
}