﻿using Terraria.Localization;
using Terraria.ModLoader;

namespace Antiaris.Items.Placeables.MusicBoxes
{
    public class CrimsonRainMusicBox : ModItem
    {
        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("CrimsonRainMusicBox");
            item.width = 30;
            item.height = 30;
            item.rare = 4;
            item.value = 100000;
            item.accessory = true;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (Crimson Rain)");
            DisplayName.AddTranslation(GameCulture.Chinese, "音乐盒（血腥之雨）");
            DisplayName.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка (Дождь Багрянца)");
        }
    }
}
