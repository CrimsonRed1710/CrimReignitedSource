using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Projectiles
{
    public class hallow_blast : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("hallow blast");

        }

        public override void SetDefaults()
        {
            projectile.aiStyle = 1;
			projectile.width = 36;
			projectile.height = 36;
            projectile.scale = 1f;
			projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.melee = true;
			projectile.penetrate = 5;
			projectile.timeLeft = 400;
			projectile.light = 1f;
            projectile.alpha = 64;
			projectile.extraUpdates = 10;   
    

        }

		public override void AI()
		{
            if(Main.rand.Next(2) == 0)
            {
            int a = Dust.NewDust(projectile.position, projectile.width, projectile.height, 204);   //this adds a vanilla terraria dust to the projectile
            Main.dust[a].noGravity = false;  //this modify the scale of the first dust
            Main.dust[a].scale = 1.3f; 
            }
        }
    }
}