using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Items.Weapons
{
	public class true_polaris : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Polaris");
			Tooltip.SetDefault("'Wait wasnt the north star just over ther- AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA'\nYou are holding the destruction of countless civilizations and downfall of the moon empire\nExplodes on impact and releases nebula blasts\nHas a chance to spawn a massive tornado vortex");
		}
		public override void SetDefaults()
		{
			item.damage = 180;
			item.thrown = true;
			item.width = 64;
			item.height = 64;
			item.useTime = 15;
			item.useAnimation = 15;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 1;
			item.knockBack = 6;
            item.value = Item.sellPrice(1, 0, 0, 0);
			item.value = 10000;
			item.rare = 10;
			item.UseSound = SoundID.Item116;
			item.autoReuse = true;
			item.shootSpeed = 25f;
			item.shoot = mod.ProjectileType ("true_polaris");

		}
		
		
		public override void AddRecipes()
		{
            ModRecipe crimson = new ModRecipe(mod);
            crimson.AddIngredient(null, "polaris");
            crimson.AddIngredient(ItemID.IceBoomerang);
            crimson.AddIngredient(ItemID.Flamarang);
            crimson.AddIngredient(ItemID.VampireKnives);
            crimson.AddIngredient(3467, 10);
			crimson.AddIngredient(3456, 10);
			crimson.AddIngredient(3457, 10);
			crimson.AddIngredient(3458, 10);
			crimson.AddIngredient(3459, 10);
			crimson.AddTile(TileID.LunarCraftingStation);
            crimson.SetResult(this);
            crimson.AddRecipe();
            
			ModRecipe corrupt = new ModRecipe(mod);
            corrupt.AddIngredient(null, "polaris");
            corrupt.AddIngredient(ItemID.IceBoomerang);
            corrupt.AddIngredient(ItemID.Flamarang);
            corrupt.AddIngredient(1571); //scourge of the corruptor
            corrupt.AddIngredient(3467, 10);
			corrupt.AddIngredient(3456, 10);
			corrupt.AddIngredient(3457, 10);
			corrupt.AddIngredient(3458, 10);
			corrupt.AddIngredient(3459, 10);
			corrupt.AddTile(TileID.LunarCraftingStation);
            corrupt.SetResult(this);
            corrupt.AddRecipe();
		}
	}
}
