using crimreignited.Projectiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Items.Weapons
{
	public class CrimsonsTrident : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crimson's Trident");
			Tooltip.SetDefault("'Inundated with Crimson's essence, don't underestimate it's power'");
		}
		public override void SetDefaults()
		{
			// Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
			item.shootSpeed = 30f;
			item.damage = 1;
			item.knockBack = 5f;
			item.useStyle = 1;
			item.useAnimation = 15;
			item.useTime = 15;
			item.width = 30;
			item.height = 30;
			item.rare = 5;
			item.expert = false;

			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.thrown = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 5);
			item.shoot = mod.ProjectileType<CrimsonsTridentProj>();
		}
		
		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "hellfire_core", 8);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
	}
}
