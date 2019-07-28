using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Projectiles
{
	public class crimson_evil : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.aiStyle = 1;
			aiType = ProjectileID.Bullet;
			projectile.ranged = true;
			projectile.penetrate = 2;
			projectile.timeLeft = 300;
			projectile.alpha = 0;
		}

		public override void AI()
		{
			int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 12);
			Main.dust[dust].noGravity = true;
			Main.dust[dust].velocity *= 0f;
			Main.dust[dust].scale *= 1.3f;
		}


		public override void Kill(int timeLeft)
		{
			for (int i = 0; i<20; i++)
            {
            
				int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 12);
				Main.dust[dust].noGravity = true;
				Main.dust[dust].velocity *= 4f;
				Main.dust[dust].scale *= 1.3f;
            }                

			Main.PlaySound(SoundID.NPCHit10, projectile.position);
		
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-5, 5), Main.rand.Next(-5, 5), mod.ProjectileType("living_gun1"), (int)(projectile.damage * 0.5), 0, Main.myPlayer); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-7, 7), Main.rand.Next(-7, 7), mod.ProjectileType("living_gun1"), (int)(projectile.damage * 0.5), 0, Main.myPlayer); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-3, 3),Main.rand.Next(-3, 3), mod.ProjectileType("living_gun1"), (int)(projectile.damage * 0.5), 0, Main.myPlayer); //Spawning a projectile
		
		
		}

	}
}