using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace crimreignited.Items.Weapons
{
    public class pulse_blaster : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pulse Blaster");
			Tooltip.SetDefault("'Because archery...'");
		}

        public override void SetDefaults()
        {
            item.damage = 55;
            item.noMelee = true;
            item.ranged = true;
            item.width = 28;
            item.height = 40;
            item.useTime = 100;
            item.useAnimation = 100;
            item.useStyle = 5;
            item.shoot = mod.ProjectileType ("pulse");
			item.useAmmo = mod.ItemType("dark_bolt");
            item.knockBack = 0;
            item.value = Item.sellPrice(0, 0, 95, 0);
            item.rare = 11;
            item.UseSound = SoundID.Item36;
            item.autoReuse = false;
            item.shootSpeed = 9f;
        }
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
            if(Main.rand.Next(1) == 0)
                {
                    Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 661, damage, 0, player.whoAmI, 0f, 0f);
                }
				return true;
          }
    }
}