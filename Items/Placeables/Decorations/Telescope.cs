﻿using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Antiaris.Items.Placeables.Decorations
{
    public class Telescope : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 48;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.rare = 1;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.createTile = mod.TileType("Telescope");
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Telescope");
            DisplayName.AddTranslation(GameCulture.Chinese, "望远镜");
            DisplayName.AddTranslation(GameCulture.Russian, "Телескоп");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Antiaris:GoldBar", 5);
            recipe.SetResult(this);
            recipe.AddTile(16);
            recipe.AddRecipe();
        }
    }
}
