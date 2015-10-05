using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlusOne.Items.Weapons
{
    public class LeadBroadswordPlusOne : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TerrariaPlusOne/Items/Weapons/LeadBroadswordPlusOne";
            return true;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Lead Broadsword +1";
            item.damage = 14;
            item.melee = true;
            item.width = 24;
            item.height = 28;
            item.useTime = 18;
            item.useAnimation = 21;
            item.useStyle = 1;
            item.knockBack = 5.5f;
            item.value = 810; // Value is in copper
            item.rare = 1;
            item.useSound = 1;
            item.autoReuse = false;
            item.scale = 1f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.LeadBroadsword, 1);
            recipe.AddIngredient(Terraria.ID.ItemID.LeadBar, 24);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
