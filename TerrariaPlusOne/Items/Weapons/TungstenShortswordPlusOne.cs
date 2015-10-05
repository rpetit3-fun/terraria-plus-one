using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlusOne.Items.Weapons
{
    public class TungstenShortswordPlusOne : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TerrariaPlusOne/Items/Weapons/TungstenShortswordPlusOne";
            return true;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Tungsten Shortsword +1";
            item.damage = 13;
            item.melee = true;
            item.width = 24;
            item.height = 28;
            item.useTime = 9;
            item.useAnimation = 12;
            item.useStyle = 3;
            item.knockBack = 4.4f;
            item.value = 1575; // Value is in copper
            item.rare = 1;
            item.useSound = 1;
            item.autoReuse = false;
            item.scale = 0.9f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.TungstenShortsword, 1);
            recipe.AddIngredient(Terraria.ID.ItemID.TungstenBar, 18);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
