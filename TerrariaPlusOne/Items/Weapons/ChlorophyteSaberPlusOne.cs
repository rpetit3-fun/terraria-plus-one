using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlusOne.Items.Weapons
{
    public class ChlorophyteSaberPlusOne : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TerrariaPlusOne/Items/Weapons/ChlorophyteSaberPlusOne";
            return true;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Chlorophyte Saber +1";
            item.damage = 60;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 13;
            item.useAnimation = 16;
            item.useStyle = 1;
            item.knockBack = 4.4f;
            item.value = 82800; // Value is in copper
            item.rare = 8;
            item.useSound = 1;
            item.autoReuse = true;
            item.scale = 1f;
            item.shoot = 228;
            item.shootSpeed = 8f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.ChlorophyteSaber, 1);
            recipe.AddIngredient(Terraria.ID.ItemID.ChlorophyteBar, 60);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
