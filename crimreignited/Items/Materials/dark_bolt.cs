using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Items.Materials
{
	public class dark_bolt : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Bolt");
			Tooltip.SetDefault("used by the Pulse Blaster\n'imbued with darkness'");
		}


		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 32;
			item.maxStack = 999;
            item.rare = 11;
            item.ammo = item.type;
            item.consumable = true;
		}

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DarkShard, 1);
			recipe.AddIngredient(ItemID.WoodenArrow, 100);
			recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 100);
            recipe.AddRecipe();
		}


		/*public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "sands_of_magic", 2);
			recipe.AddIngredient(null, "manganese_bar",3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 6);
			recipe.AddRecipe();
		}*/
	}
}
