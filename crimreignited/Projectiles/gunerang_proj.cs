using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Projectiles
{
	public class gunerang_proj : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 42;
			projectile.height = 46;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.aiStyle = 3;
			projectile.penetrate = -1;
			projectile.timeLeft = 800;
            projectile.netUpdate = true;
		}


        public override bool OnTileCollide(Vector2 oldVelocity)
		{
            int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(7, 7), Main.rand.Next(-10, 10), 14, projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f);
			
			if (projectile.velocity.X != oldVelocity.X)
			{
				projectile.velocity.X = -oldVelocity.X;
			}
			if (projectile.velocity.Y != oldVelocity.Y)
			{
				projectile.velocity.Y = -oldVelocity.Y;
			}
			return false;
		}      
		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(7, 7), Main.rand.Next(-10, 10), 14, projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f);
		}
	}
}