using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlusOne.Items.Weapons
{
    public class NightsEdgePlusOne : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TerrariaPlusOne/Items/Weapons/NightsEdgePlusOne";
            return true;
        }


        public override void SetDefaults()
        {
            base.SetDefaults();
            item.name = "Night's Edge +1";
            item.damage = 53;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 23;
            item.useAnimation = 27;
            item.useStyle = 1;
            item.knockBack = 4.95f;
            item.value = 16200; // Value is in copper
            item.rare = 4;
            item.useSound = 1;
            item.autoReuse = false;
            item.scale = 1.15f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.NightsEdge, 1);
            recipe.AddIngredient(null, "BloodButchererPlusOne", 1);
            recipe.AddIngredient(null, "FieryGreatswordPlusOne", 1);
            recipe.AddIngredient(null, "BladeofGrassPlusOne", 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(Terraria.ID.ItemID.NightsEdge, 1);
            recipe.AddIngredient(null, "FieryGreatswordPlusOne", 1);
            recipe.AddIngredient(null, "BladeofGrassPlusOne", 1);
            recipe.AddIngredient(null, "LightsBanePlusOne", 1);
            recipe.AddTile(TileID.DemonAltar);
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
                DustID.Shadowflame,
                (player.velocity.X * 0.2f) + (player.direction * 2),
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
