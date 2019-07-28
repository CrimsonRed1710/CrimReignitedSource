using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;         
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Items.Everglade
{
	public class vivianite : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vivianite");			
			Tooltip.SetDefault("Fully pure and crystalized everglade");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.rare = 2;
            item.value = Item.sellPrice(0, 0, 1, 0);
			item.createTile = mod.TileType("vivianite");
		}

	}
}