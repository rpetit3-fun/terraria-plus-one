using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlusOne.Items.Weapons
{
    public class TrueNightsEdgePlusOne : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TerrariaPlusOne/Items/Weapons/TrueNightsEdgePlusOne";
            return true;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "True Night's Edge +1";
            item.damage = 113;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 22;
            item.useAnimation = 26;
            item.useStyle = 1;
            item.knockBack = 5.23f;
            item.value = 150000; // Value is in copper
            item.rare = 9;
            item.useSound = 1;
            item.autoReuse = false;
            item.scale = 1.15f;
            item.shoot = 157;
            item.shootSpeed = 10f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.TrueNightsEdge, 1);
            recipe.AddIngredient(null, "NightsEdgePlusOne", 1);
            recipe.AddIngredient(Terraria.ID.ItemID.BrokenHeroSword, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
