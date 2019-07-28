using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Items.Lettuce
{
    public class lettuce_proj : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("lettuce_proj");

        }

        public override void SetDefaults()
        {
			projectile.width = 20;
			projectile.height = 20;
            projectile.scale = 1f;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.aiStyle = 14;
			projectile.penetrate = 4;
			projectile.timeLeft = 300;
            projectile.alpha = 0;			
			projectile.extraUpdates = 1;
			projectile.netUpdate = true;
        }

        public override void Kill(int timeLeft)
        {
            for (int i=0; i<10; i++)
            {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 3);   //this adds a vanilla terraria dust to the projectile
            Main.dust[dust].noGravity = true;  //this modify the scale of the first dust
            Main.dust[dust].scale = 1.8f;
            }
        } 
    }
}