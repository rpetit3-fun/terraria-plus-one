using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlusOne.Items.Weapons
{
    public class AdamantiteSwordPlusOne : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TerrariaPlusOne/Items/Weapons/AdamantiteSwordPlusOne";
            return true;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Adamantite Sword +1";
            item.damage = 63;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 23;
            item.useAnimation = 27;
            item.useStyle = 1;
            item.knockBack = 6.6f;
            item.value = 41400; // Value is in copper
            item.rare = 5;
            item.useSound = 1;
            item.autoReuse = true;
            item.scale = 1.2f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.AdamantiteSword, 1);
            recipe.AddIngredient(Terraria.ID.ItemID.AdamantiteBar, 60);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
