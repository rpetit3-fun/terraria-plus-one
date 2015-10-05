using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlusOne.Items.Weapons
{
    public class BladeofGrassPlusOne : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TerrariaPlusOne/Items/Weapons/BladeofGrassPlusOne";
            return true;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Blade of Grass +1";
            item.damage = 35;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 26;
            item.useAnimation = 30;
            item.useStyle = 1;
            item.knockBack = 3.3f;
            item.value = 8100; // Value is in copper
            item.rare = 4;
            item.useSound = 1;
            item.autoReuse = false;
            item.scale = 1.4f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.BladeofGrass, 1);
            recipe.AddIngredient(Terraria.ID.ItemID.JungleSpores, 42);
            recipe.AddIngredient(Terraria.ID.ItemID.Stinger, 42);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
