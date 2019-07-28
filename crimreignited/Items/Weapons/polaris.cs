using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Items.Weapons
{
	public class polaris : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Polaris");
			Tooltip.SetDefault("'Shines toward the northern sky'");
		}
		public override void SetDefaults()
		{
			item.damage = 100;
			item.thrown = true;
			item.width = 48;
			item.height = 58;
			item.useTime = 10;
			item.useAnimation = 10;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 1;
			item.knockBack = 6;
            item.value = Item.sellPrice(0, 25, 0, 0);
			item.value = 10000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 15f;
			item.shoot = mod.ProjectileType ("polaris");

		}

	}
}
