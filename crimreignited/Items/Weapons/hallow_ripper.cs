using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Items.Weapons
{
	public class hallow_ripper : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hallow Ripper");
			Tooltip.SetDefault("'Rippin it'\nRight click fire a sawblade");
		}
		public override void SetDefaults()
		{
			item.damage = 75;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 5;
            item.value = Item.sellPrice(0, 0, 0, 5);
			item.rare = 10;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            
			item.shootSpeed = 7f;

		}
 
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
 
        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)     //2 is right click
            {
                item.noMelee = true;
                item.noUseGraphic = false;
                item.useTime = 30;
                item.useAnimation = 30;
				item.shoot = mod.ProjectileType("hallow_blast");    
			}
            if (player.altFunctionUse != 2  && player.ownedProjectileCounts[item.shoot] < 1)    
			{
                item.noMelee = false;
                item.noUseGraphic = false;
				item.useTime = 10;
				item.useAnimation = 30;
				item.shoot = 0;
			}
            return base.CanUseItem(player) && player.ownedProjectileCounts[item.shoot] < 1;
        }	
	}
}