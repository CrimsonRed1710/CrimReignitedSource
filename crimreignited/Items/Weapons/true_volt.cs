using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Items.Weapons
{
	public class true_volt : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Volt");
			Tooltip.SetDefault("Shoots a bouncing dune projectile that releases volts when hitting blocks\nRight click to stab");
		}
		public override void SetDefaults()
		{
			item.damage = 120;
			item.melee = true;
			item.width = 64;
			item.height = 66;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 6;
            item.value = Item.sellPrice(0, 28, 0, 0);
			item.rare = 7;
			item.UseSound = SoundID.Item60;
            item.autoReuse = true;            
			item.shootSpeed = 10f;

		}
 
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
 
        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)     //2 is right click
            {
				item.damage = 150;
                item.useTime = 7;
                item.useAnimation = 7;
			    item.useStyle = 3;                
				item.shoot = 0;                
			}
            if (player.altFunctionUse != 2)    
			{
				item.damage = 120;				
				item.useTime = 18;
				item.useAnimation = 18;
			    item.useStyle = 1;                                
				item.shoot = mod.ProjectileType("true_volt");
			}
            return base.CanUseItem(player);


        }	
        
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "volt");
            recipe.AddIngredient(ItemID.BrokenHeroSword);
			recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        	
	}
}
