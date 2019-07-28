using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace crimreignited.Items.Weapons
{
    public class worlds_evil : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("World's Evil");
			Tooltip.SetDefault("'Two evils'\nMade to harness the power of the world evils\nWhen walking into the Crimson/Corruption your weapon is charged with it's power\nIn the hallowed your weapon is purified of all evil");
		}

        public override void SetDefaults()
        {
            item.damage = 0;
            item.noMelee = true;
            item.magic = true;
            item.width = 48;
            item.height = 32;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 1, 30, 0);
            item.rare = 5;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shootSpeed = 10f;

        }
        int temporalProj = 0;
        public override void UpdateInventory(Player player) //tremor oof
        {
            if (Main.player[Main.myPlayer].ZoneCrimson)
            {
                item.damage = 55;
                item.useTime = 20;
                item.useAnimation = 15;
                item.shoot = mod.ProjectileType ("crimson_evil");
            }
            if (Main.player[Main.myPlayer].ZoneCorrupt)
            {
                item.damage = 35;
                item.useTime = 15;
                item.useAnimation = 30;
                item.shoot = 307;
			}
			if (Main.player[Main.myPlayer].ZoneHoly)
		    {
                item.damage = 0;
                item.useTime = 0;
                item.useAnimation = 0;
			}
        }
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-3, 0);
		} 
		
		public override void AddRecipes()
		{
            ModRecipe crimson = new ModRecipe(mod);
			crimson.AddIngredient(1332, 15);//ichor
			crimson.AddIngredient(2886, 50);//vicious powder
			crimson.AddIngredient(1257, 30);//crimtane bars
			crimson.AddTile(TileID.MythrilAnvil);
            crimson.SetResult(this);
            crimson.AddRecipe();
            
			ModRecipe corrupt = new ModRecipe(mod);
			corrupt.AddIngredient(522, 15);//cursed flame
			corrupt.AddIngredient(67, 50);//vile powder
			corrupt.AddIngredient(57, 30);//demonite bars
			corrupt.AddTile(TileID.MythrilAnvil);
            corrupt.SetResult(this);
            corrupt.AddRecipe();
		}		
    }
}