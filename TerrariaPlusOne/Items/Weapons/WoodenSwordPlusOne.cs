using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlusOne.Items.Weapons
{
    public class WoodenSwordPlusOne : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TerrariaPlusOne/Items/Weapons/WoodenSwordPlusOne";
            return true;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Wooden Sword +1";
            item.damage = 9;
            item.melee = true;
            item.width = 24;
            item.height = 28;
            item.useTime = 21;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.knockBack = 4.4f;
            item.value = 30; // Value is in copper
            item.rare = 1;
            item.useSound = 1;
            item.autoReuse = false;
            item.scale = 0.95f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.WoodenSword, 1);
            recipe.AddIngredient(Terraria.ID.ItemID.Wood, 14);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
