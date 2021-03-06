using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlusOne.Items.Weapons
{
    public class RichMahoganySwordPlusOne : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TerrariaPlusOne/Items/Weapons/RichMahoganySwordPlusOne";
            return true;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Rich Mahogany Sword +1";
            item.damage = 10;
            item.melee = true;
            item.width = 24;
            item.height = 28;
            item.useTime = 19;
            item.useAnimation = 23;
            item.useStyle = 1;
            item.knockBack = 5.5f;
            item.value = 30; // Value is in copper
            item.rare = 1;
            item.useSound = 1;
            item.autoReuse = false;
            item.scale = 1f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.RichMahoganySword, 1);
            recipe.AddIngredient(Terraria.ID.ItemID.RichMahogany, 14);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
