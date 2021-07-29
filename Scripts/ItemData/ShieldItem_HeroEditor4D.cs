﻿using MultiplayerARPG.HeroEditor4D;

namespace MultiplayerARPG
{
    public partial class ShieldItem : IHeroEditorItem
    {
        [Category(11, "In-Scene Objects/Appearance (HeroEditor4D)")]
        public HeroEditorSpriteData spriteData;
        public HeroEditorSpriteData SpriteData { get { return spriteData; } }
    }
}
