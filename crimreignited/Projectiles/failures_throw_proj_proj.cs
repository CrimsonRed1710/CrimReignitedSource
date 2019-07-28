using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Projectiles
{
    public class failures_throw_proj_proj : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("thing");

        }

        public override void SetDefaults()
        {
			projectile.CloneDefaults(316);
			aiType = 316;
            projectile.ignoreWater = true;
            projectile.magic = false;
			projectile.width = 4;
			projectile.height = 4;
            projectile.melee = true;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 500;
            projectile.alpha = 255;			
			projectile.extraUpdates = 100;
        }
		
        public override void AI()
        {
            Dust dust1 = Dust.NewDustDirect(projectile.Center, 0, 0, 222);
            dust1.noGravity = true;
            dust1.scale = 2f;
            dust1.velocity *= 0f;
        }
        public override void Kill(int timeLeft)        
        {
			for (int i = 0; i < 10; i++)
            {
				Dust dust = Dust.NewDustDirect(projectile.Center, projectile.width, projectile.height, 222);
				dust.noGravity = true;
				dust.scale = 0.7f;
                dust.velocity *= 4f;
            }                
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, 0, 612, projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f);
        }
    }
}