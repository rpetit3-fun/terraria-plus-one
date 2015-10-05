using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlusOne.Items.Weapons
{
    public class PalladiumSwordPlusOne : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TerrariaPlusOne/Items/Weapons/PalladiumSwordPlusOne";
            return true;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Palladium Sword +1";
            item.damage = 52;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 21;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.knockBack = 5.23f;
            item.value = 27600; // Value is in copper
            item.rare = 5;
            item.useSound = 1;
            item.autoReuse = true;
            item.scale = 1.125f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.PalladiumSword, 1);
            recipe.AddIngredient(Terraria.ID.ItemID.PalladiumBar, 42);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
