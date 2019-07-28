using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Projectiles
{
    public class true_volt : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("True Volt");

        }

        public override void SetDefaults()
        {
			projectile.width = 30;
			projectile.height = 30;
            projectile.aiStyle = 1;
            aiType = ProjectileID.Bullet; 			
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = 5;
			projectile.timeLeft = 600;
            projectile.alpha = 0;			
            projectile.light = 0.7f;
			projectile.extraUpdates = 1;


        }
		
        public override bool PreKill(int timeLeft)
		{
			projectile.type = 116;
			return false;
		}

        
        
        
        public override bool OnTileCollide(Vector2 oldVelocity)
		{
            projectile.penetrate--;
            int damamge = projectile.damage / 5;

            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, -3, -3, mod.ProjectileType("volt"), damamge, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, -3, 3, mod.ProjectileType("volt"), damamge, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 3, -3, mod.ProjectileType("volt"), damamge, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 3, 3, mod.ProjectileType("volt"), damamge, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile

            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, 5, mod.ProjectileType("volt"), damamge, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 5, 0, mod.ProjectileType("volt"), damamge, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, -5, mod.ProjectileType("volt"), damamge, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, -5, 0, mod.ProjectileType("volt"), damamge, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile

			if (projectile.velocity.X != oldVelocity.X)
			{
				projectile.velocity.X = -oldVelocity.X;
			}
			if (projectile.velocity.Y != oldVelocity.Y)
			{
				projectile.velocity.Y = -oldVelocity.Y;
			}
			
			Main.PlaySound(SoundID.Item120, projectile.position);        
            
            for (int i = 0; i<30; i++)
            {            
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 185);   //this adds a vanilla terraria dust to the projectile
				Main.dust[dust].velocity *= 4f;
				Main.dust[dust].scale = 2f;
                Main.dust[dust].noGravity = true;  //this modify the scale of the first dust
            }
            
            return false;
		}                

    }
}