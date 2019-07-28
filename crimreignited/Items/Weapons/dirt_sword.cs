using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Items.Weapons
{
	public class dirt_sword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dirt Sword");
			Tooltip.SetDefault("pls no");
		}
		public override void SetDefaults()
		{
			item.damage = 1;
			item.melee = true;
			item.width = 32;
			item.height = 38;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 0;
			item.useTurn = true; //this allows the movement of sword like muramasa
            item.value = Item.sellPrice(0, 0, 0, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item1;        
			item.shootSpeed = 10f;
			item.autoReuse = true;

		}
        
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(TileID.Dirt, 999);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}
