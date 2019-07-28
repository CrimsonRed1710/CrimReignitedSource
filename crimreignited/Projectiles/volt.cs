using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Projectiles
{
    public class volt : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
        
		    DisplayName.SetDefault("volt laser");

        }

        public override void SetDefaults()
        {
			projectile.width = 4;
			projectile.height = 48;
            projectile.scale = 0.7f;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 600;
            projectile.alpha = 0;			
			projectile.extraUpdates = 1;
            aiType = ProjectileID.Bullet; 			

        }
		public override void Kill(int timeLeft)
		{
			Main.PlaySound(SoundID.Item73, projectile.position);
            for (int i = 0; i<20; i++)
            {            
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 185);   //this adds a vanilla terraria dust to the projectile
				Main.dust[dust].velocity *= 3f;
            }
        }
        
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            target.AddBuff(31, 300);        //confused debuff
        }
    
    
    }
}