using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlusOne.Items.Weapons
{
    public class CopperShortswordPlusOne : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TerrariaPlusOne/Items/Weapons/CopperShortswordPlusOne";
            return true;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Copper Shortsword +1";
            item.damage = 7;
            item.melee = true;
            item.width = 24;
            item.height = 28;
            item.useTime = 10;
            item.useAnimation = 12;
            item.useStyle = 3;
            item.knockBack = 4.4f;
            item.value = 105; // Value is in copper
            item.rare = 1;
            item.useSound = 1;
            item.autoReuse = false;
            item.scale = 0.9f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.CopperShortsword, 1);
            recipe.AddIngredient(Terraria.ID.ItemID.CopperBar, 14);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
