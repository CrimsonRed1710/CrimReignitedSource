using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;         
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace crimreignited.Items
{
	public class hellfire_core : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hellfire Core");			
			Tooltip.SetDefault("Hot to the touch...");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 1, 0);
			item.rare = 4;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "hellfire_shard", 4);
			recipe.AddIngredient(ItemID.Obsidian, 1);
			recipe.SetResult(this);
			recipe.AddTile(TileID.Anvils);
			recipe.AddRecipe();
		}
	}
}
