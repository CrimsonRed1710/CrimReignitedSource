using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Items.Weapons
{
	public class gunerang : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gunerang");
			Tooltip.SetDefault("'Keep coming back'\nLeft click to throw the gunerang");
		}
		public override void SetDefaults()
		{
			item.damage = 25;
			item.ranged = true;
			item.width = 42;
			item.height = 46;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 5;
            item.value = Item.sellPrice(0, 10, 0, 0);
			item.rare = 10;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            
			item.shootSpeed = 15f;
			item.scale = 0.7f;
		}
 
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
 
        public override bool CanUseItem(Player player)
        {
            {
				item.damage = 25;
                item.noMelee = true;
                item.noUseGraphic = true;
                item.useTime = 30;
                item.useAnimation = 30;
				item.shoot = mod.ProjectileType("gunerang_proj");    
			}
            return base.CanUseItem(player) && player.ownedProjectileCounts[item.shoot] < 1;
        }	
	}
}
