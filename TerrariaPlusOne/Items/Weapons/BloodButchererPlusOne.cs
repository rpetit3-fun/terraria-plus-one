using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlusOne.Items.Weapons
{
    public class BloodButchererPlusOne : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TerrariaPlusOne/Items/Weapons/BloodButchererPlusOne";
            return true;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Blood Butcherer +1";
            item.damage = 28;
            item.melee = true;
            item.width = 24;
            item.height = 28;
            item.useTime = 21;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.knockBack = 5.5f;
            item.value = 4050; // Value is in copper
            item.rare = 2;
            item.useSound = 1;
            item.autoReuse = false;
            item.scale = 1.1f;
            item.toolTip = "'It's way more bloodier this time!'";
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.BloodButcherer, 1);
            recipe.AddIngredient(Terraria.ID.ItemID.CrimtaneBar, 40);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            Color color = new Color();
            int dust = Dust.NewDust(
                new Vector2(hitbox.X, hitbox.Y),
                hitbox.Width + 5,
                hitbox.Height + 5,
                DustID.Blood,
                (player.velocity.X * 0.2f) + (player.direction * 6),
                player.velocity.Y * 0.2f,
                100,
                color,
                1.5f
            );
            Main.dust[dust].noGravity = true;
            Main.dust[dust].noLight = false;
        }
    }
}
