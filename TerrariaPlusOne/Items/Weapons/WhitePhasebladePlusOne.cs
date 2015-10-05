using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlusOne.Items.Weapons
{
    public class WhitePhasebladePlusOne : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TerrariaPlusOne/Items/Weapons/WhitePhasebladePlusOne";
            return true;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "White Phaseblade +1";
            item.damage = 27;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 21;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.knockBack = 3.3f;
            item.value = 8100; // Value is in copper
            item.rare = 2;
            item.useSound = 1;
            item.autoReuse = true;
            item.scale = 1f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.WhitePhaseblade, 1);
            recipe.AddIngredient(Terraria.ID.ItemID.MeteoriteBar, 45);
            recipe.AddIngredient(Terraria.ID.ItemID.Ruby, 30);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
