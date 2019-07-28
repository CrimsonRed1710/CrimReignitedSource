using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;         
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace crimreignited.Items
{
	public class hellfire_shard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hellfire Shard");			
			Tooltip.SetDefault("Dropped from demons trapped in the underworld");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 24;
			item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 0, 20);
			item.rare = 4;
		}
	}
}
