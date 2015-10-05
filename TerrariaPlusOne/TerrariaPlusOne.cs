using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TerrariaPlusOne.Items.Weapons;

namespace TerrariaPlusOne {
    public class TerrariaPlusOne : Mod {
        public override void SetModInfo(out string name, ref ModProperties properties) {
            name = "TerrariaPlusOne";
            properties.Autoload = true;
            properties.AutoloadGores = true;
            properties.AutoloadSounds = true;

            AddItem("WoodenSwordPlusOne", new WoodenSwordPlusOne(), "Items/Weapons");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(Terraria.ID.ItemID.Wood, 5);
            recipe.SetResult(ItemID.Wood, 999);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(Terraria.ID.ItemID.CopperBar, 1);
            recipe.AddIngredient(Terraria.ID.ItemID.SilverBar, 1);
            recipe.AddIngredient(Terraria.ID.ItemID.GoldBar, 1);
            recipe.AddTile(TileID.Tables);
            recipe.AddTile(TileID.Chairs);
            recipe.SetResult(Terraria.ID.ItemID.DepthMeter, 1);
            recipe.AddRecipe();
        }
    }
}
