using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlusOne.Items.Weapons
{
    public class TungstenBroadswordPlusOne : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TerrariaPlusOne/Items/Weapons/TungstenBroadswordPlusOne";
            return true;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Tungsten Broadsword +1";
            item.damage = 15;
            item.melee = true;
            item.width = 24;
            item.height = 28;
            item.useTime = 17;
            item.useAnimation = 21;
            item.useStyle = 1;
            item.knockBack = 5.5f;
            item.value = 2025; // Value is in copper
            item.rare = 1;
            item.useSound = 1;
            item.autoReuse = false;
            item.scale = 1f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.TungstenBroadsword, 1);
            recipe.AddIngredient(Terraria.ID.ItemID.TungstenBar, 24);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
