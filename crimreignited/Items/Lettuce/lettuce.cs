using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;         
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Items.Lettuce
{
	[AutoloadEquip(EquipType.Head)]
	public class lettuce : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Lettuce");			
			Tooltip.SetDefault("90% water, 100% lettuce...");
		}

		public override void SetDefaults()
		{
			item.width = 34;
			item.height = 34;
            item.value = Item.sellPrice(0, 0, 0, 0);
			item.rare = 2;
			item.damage = 1;
			item.thrown = true;
			item.useTime = 22;
			item.useAnimation = 22;
            item.noMelee = true;
			item.noUseGraphic = true;
			item.useStyle = 1;
			item.knockBack = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 3f;
			item.shoot = mod.ProjectileType ("lettuce_proj");
		}
	}
}
