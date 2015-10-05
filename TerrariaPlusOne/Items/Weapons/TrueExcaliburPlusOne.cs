using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlusOne.Items.Weapons
{
    public class TrueExcaliburPlusOne : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TerrariaPlusOne/Items/Weapons/TrueExcaliburPlusOne";
            return true;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "True Excalibur +1";
            item.damage = 83;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 13;
            item.useAnimation = 16;
            item.useStyle = 1;
            item.knockBack = 4.95f;
            item.value = 150000; // Value is in copper
            item.rare = 9;
            item.useSound = 1;
            item.autoReuse = false;
            item.scale = 1.05f;
            item.shoot = 156;
            item.shootSpeed = 11f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.TrueExcalibur, 1);
            recipe.AddIngredient(null, "ExcaliburPlusOne", 1);
            recipe.AddIngredient(Terraria.ID.ItemID.BrokenHeroSword, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
