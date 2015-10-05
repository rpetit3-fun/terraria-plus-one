using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlusOne.Items.Weapons
{
    public class BladeofGrassPlusOne : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TerrariaPlusOne/Items/Weapons/BladeofGrassPlusOne";
            return true;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Blade of Grass +1";
            item.damage = 35;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 26;
            item.useAnimation = 30;
            item.useStyle = 1;
            item.knockBack = 3.3f;
            item.value = 8100; // Value is in copper
            item.rare = 4;
            item.useSound = 1;
            item.autoReuse = false;
            item.scale = 1.4f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.BladeofGrass, 1);
            recipe.AddIngredient(Terraria.ID.ItemID.JungleSpores, 42);
            recipe.AddIngredient(Terraria.ID.ItemID.Stinger, 42);
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
                DustID.GrassBlades,
                (player.velocity.X * 0.2f) + (player.direction * 5),
                player.velocity.Y * 0.2f,
                100,
                color,
                1.5f
            );
            Main.dust[dust].noGravity = true;
            Main.dust[dust].noLight = false;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            if(Main.rand.Next(2) == 0)
            {
                target.AddBuff(BuffID.Poisoned, 500);
            }
        }
    }
}
