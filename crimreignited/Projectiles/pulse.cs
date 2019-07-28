using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Projectiles
{
    public class pulse : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("pulse");

        }

        public override void SetDefaults()
        {
			projectile.width = 14;
			projectile.height = 32;
			projectile.friendly = true;
			projectile.aiStyle = -1;
			projectile.penetrate = -1;
			projectile.timeLeft = 75;
            projectile.alpha = 100;			
			projectile.extraUpdates = 1;
        }
		
        public override void Kill(int timeLeft)        
        {
            for (int i = 0; i<15; i++)
            {            
			Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 54);
			dust.scale = 0.7f;
			dust.velocity *= 6f;
			}
			Main.PlaySound(SoundID.Item36, projectile.position); 
			
            int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(7, 7), Main.rand.Next(-10, 10), 661, projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f);			
        } 
		
		public override void AI()
		{
			projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2;
		}
    }
}