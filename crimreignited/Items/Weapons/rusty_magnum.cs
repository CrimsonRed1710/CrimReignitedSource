using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace crimreignited.Items.Weapons
{
    public class rusty_magnum : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rusty Magnum");
			Tooltip.SetDefault("'Remenant of an age long gone'\nHas a chance to shoot nothing");
		}

        public override void SetDefaults()
        {
            item.damage = 9;
            item.noMelee = true;
            item.ranged = true;
            item.width = 42;
            item.height = 30;
            item.useTime = 27;
            item.useAnimation = 9;
            item.useStyle = 5;
            item.shoot = 10;
            item.useAmmo = AmmoID.Bullet;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 0, 95, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shootSpeed = 20f;

        }


		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
            if(Main.rand.Next(3) == 0)
                {
                    Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 0, damage, 0, player.whoAmI, 0f, 0f);
                    return false;
                }
                else
                {
                    return true;
                }
          }

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-3, 0);
		}          
    }
}