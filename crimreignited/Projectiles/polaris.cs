using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Projectiles
{
    public class polaris : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("polaris");

        }

        public override void SetDefaults()
        {
            projectile.aiStyle = 3;
			projectile.width = 48;
			projectile.height = 58;
            projectile.scale = 1f;
			projectile.friendly = true;
			projectile.tileCollide = false;
			projectile.thrown = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 800;
			projectile.light = 0.1f;
            projectile.alpha = 64;
			projectile.extraUpdates = 10;   
    

        }

		public override void AI()
		{
            if(Main.rand.Next(2) == 0)
            {
            int a = Dust.NewDust(projectile.position, projectile.width, projectile.height, 230);   //this adds a vanilla terraria dust to the projectile
            Main.dust[a].noGravity = true;  //this modify the scale of the first dust
            Main.dust[a].scale = 1.3f; 
            }
        }


        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            target.immune[projectile.owner] = 0;


            int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-10, 10), Main.rand.Next(-10, 10), 464, projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            Main.projectile[a].friendly = true;
            Main.projectile[a].hostile = false;

            
        }
        
    }
}