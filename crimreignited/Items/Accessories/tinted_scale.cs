using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Items.Accessories
{
	public class tinted_scale : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tinted Scale");
			Tooltip.SetDefault("'Scale tinted orange from the minerals seeping from the deep'\nYour movement is no longer hindered by water\nIncreases movement speed by 20%");
		}
        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 34;
            item.value = Item.sellPrice(0, 0, 75, 0);
            item.rare = 3;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.moveSpeed += 0.20f;
            player.ignoreWater = true;
        }
    }
}
/*
            player.noFallDmg = true; 
            player.canRocket = true;
            player.rocketTime = 1200;
            player.rocketBoots = 1;
            player.rocketTimeMax = 1200;
            player.aggro += 300;
            player.meleeCrit += 17;
            player.meleeDamage += 0.22f;
            player.meleeSpeed += 0.15f;
            player.moveSpeed += 2.15f;
            player.rangedCrit += 7;
            player.rangedDamage += 0.16f;
            player.maxMinions++;
            player.minionDamage += 0.22f;
            player.statManaMax2 += 60;
            player.manaCost -= 0.15f;
            player.magicCrit += 7;
            player.magicDamage += 1.07f;
*/