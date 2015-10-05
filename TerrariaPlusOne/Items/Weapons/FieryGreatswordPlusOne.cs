using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlusOne.Items.Weapons
{
    public class FieryGreatswordPlusOne : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TerrariaPlusOne/Items/Weapons/FieryGreatswordPlusOne";
            return true;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Fiery Greatsword +1";
            item.damage = 45;
            item.melee = true;
            item.width = 24;
            item.height = 28;
            item.useTime = 29;
            item.useAnimation = 34;
            item.useStyle = 1;
            item.knockBack = 7.15f;
            item.value = 8100; // Value is in copper
            item.rare = 4;
            item.useSound = 1;
            item.autoReuse = false;
            item.scale = 1.3f;
            item.toolTip = "'It's made out of even more fire!'";
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.FieryGreatsword, 1);
            recipe.AddIngredient(Terraria.ID.ItemID.HellstoneBar, 70);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            for(int k = 0; k < 2; k++) {
                Color color = new Color();
                int dust = Dust.NewDust(
                    new Vector2(hitbox.X, hitbox.Y),
                    hitbox.Width + 5,
                    hitbox.Height + 5,
                    DustID.Fire,
                    (player.velocity.X * 0.2f) + (player.direction * 6),
                    player.velocity.Y * 0.2f,
                    100,
                    color,
                    2.5f
                );
                Main.dust[dust].noGravity = true;
                Main.dust[dust].noLight = false;
            }
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            if(Main.rand.Next(2) == 0)
            {
                target.AddBuff(BuffID.OnFire, 500);
            }
        }
    }
}
