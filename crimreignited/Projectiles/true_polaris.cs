using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Projectiles
{
    public class true_polaris : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("true polaris");

        }

        public override void SetDefaults()
        {
			projectile.width = 64;
			projectile.height = 64;
			projectile.friendly = true;
            projectile.aiStyle = 3;
			projectile.tileCollide = false;
			projectile.thrown = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 800;
			projectile.light = 0.5f;
            projectile.alpha = 64;
			projectile.extraUpdates = 1;   
    

        }


        public override void AI()
        {
            if(Main.rand.Next(10) == 0)
            {
            int a = Dust.NewDust(projectile.position, projectile.width, projectile.height, 20);   //this adds a vanilla terraria dust to the projectile
            Main.dust[a].noGravity = true;  //this modify the scale of the first dust
            Main.dust[a].velocity *= 0f; 
            }
            double count = projectile.ai[1];    //i think projectile.ai[1] is another type of tick count passed by the projectile.....?
            double spawn = count % 20;
            
            if(spawn==0)
            {
                int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-5, 5), Main.rand.Next(-5, 5), 635, (int)(projectile.damage / 3), 0, Main.myPlayer); //Spawning a projectile
                Main.projectile[a].magic = false;
                Main.projectile[a].thrown = true;
                Main.projectile[a].scale = 0.2f;
                Main.projectile[a].tileCollide = false;
            }

            projectile.ai[1] += 1f;
        
        
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-10, 10), Main.rand.Next(-10, 10), 464, projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            Main.projectile[a].friendly = true;
            Main.projectile[a].hostile = false;
            Main.projectile[a].thrown = true;


            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, 0, 612, projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            if(Main.rand.Next(9) == 0)
            {
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, 0, mod.ProjectileType("vortexStart"), projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile                
            }
        }
        
    }
}