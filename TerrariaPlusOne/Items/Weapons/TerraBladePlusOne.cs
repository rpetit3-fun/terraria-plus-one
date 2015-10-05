using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlusOne.Items.Weapons
{
    public class TerraBladePlusOne : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TerrariaPlusOne/Items/Weapons/TerraBladePlusOne";
            return true;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Terra Blade +1";
            item.damage = 119;
            item.melee = true;
            item.width = 30;
            item.height = 30;
            item.useTime = 13;
            item.useAnimation = 16;
            item.useStyle = 1;
            item.knockBack = 7.15f;
            item.value = 300000; // Value is in copper
            item.rare = 9;
            item.useSound = 1;
            item.autoReuse = true;
            item.scale = 1.1f;
            item.shoot = 132;
            item.shootSpeed = 12f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.TerraBlade, 1);
            recipe.AddIngredient(null, "TrueExcaliburPlusOne", 1);
            recipe.AddIngredient(null, "TrueNightsEdgePlusOne", 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
