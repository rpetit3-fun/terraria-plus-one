using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlusOne.Items.Weapons
{
    public class LightsBanePlusOne : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TerrariaPlusOne/Items/Weapons/LightsBanePlusOne";
            return true;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Light's Bane +1";
            item.damage = 22;
            item.melee = true;
            item.width = 24;
            item.height = 28;
            item.useTime = 17;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 5.5f;
            item.value = 4050; // Value is in copper
            item.rare = 2;
            item.useSound = 1;
            item.autoReuse = false;
            item.scale = 1.1f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.LightsBane, 1);
            recipe.AddIngredient(Terraria.ID.ItemID.DemoniteBar, 30);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
