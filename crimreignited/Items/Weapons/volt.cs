using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Items.Weapons
{
	public class volt : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Volt");
			Tooltip.SetDefault("'A little lightning never hurt anyone...'\nRight click to stab");
		}
		public override void SetDefaults()
		{
			item.damage = 45;
			item.melee = true;
			item.width = 42;
			item.height = 46;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 4;
            item.value = Item.sellPrice(0, 12, 0, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;            
			item.shootSpeed = 5f;

		}
 
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
 
        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)     //2 is right click
            {
 
                item.useTime = 13;
                item.useAnimation = 13;
			    item.useStyle = 3;                
				item.shoot = 0;                
			}
            if (player.altFunctionUse != 2)    
			{
				item.useTime = 15;
				item.useAnimation = 15;
			    item.useStyle = 1;                                
				item.shoot = mod.ProjectileType("volt");
			}
            return base.CanUseItem(player);


        }		
	}
}
