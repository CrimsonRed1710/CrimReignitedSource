using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Projectiles
{
    public class failures_throw_proj : ModProjectile  
    { 
        public override void SetStaticDefaults()
        {
		DisplayName.SetDefault("Failure's Throw");
        }

        public override void SetDefaults()
        {
            projectile.extraUpdates = 1;
            projectile.width = 16;
            projectile.height = 16;
            projectile.aiStyle = 99;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.light = 0.4f;
            projectile.melee = true;
            ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = -1f;
            ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 660f;
            ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 21f;
        }

        bool isShooting;
        float saveShotX;
        float saveShotY;
        float saveShotDistance; //all these to save last targetted noc
        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            if (!player.active)
            {
                projectile.active = false;
                return;
            }


            bool isShooting = false; //at first, this proj will assume that it hasnt shot, when it shoots, it wil send information of the target to shoot block**
            for(int i = 0; i < 200; i++)
            {
                NPC target = Main.npc[i];
                if(Main.npc[i].CanBeChasedBy(this, ignoreDontTakeDamage: true))
                {
                    float shootToX = target.Center.X - projectile.Center.X;
                    float shootToY = target.Center.Y - projectile.Center.Y;
                    float distance = (float)System.Math.Sqrt((double)(shootToX * shootToX + shootToY * shootToY));

                    shootToX *= 5f / distance;
                    shootToY *= 5f / distance;

                    if(!target.friendly && distance < 480 && Collision.CanHit(projectile.position, projectile.width, projectile.height, Main.npc[i].position, Main.npc[i].width, Main.npc[i].height))
                    {
                        saveShotX = shootToX;
                        saveShotY = shootToY;
                        saveShotDistance = distance;
                        isShooting = true;
                    }   
                }
            } 
            if(isShooting) //** this shoot block
            {
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, saveShotX, saveShotY, mod.ProjectileType("failures_throw_proj_proj"), projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
                isShooting = false;
			    Main.PlaySound(SoundID.Item75, projectile.position);
            }
            if(Main.rand.Next(14) == 1)
            {
                Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 222);
                dust.noGravity = true;
                dust.velocity.X = projectile.velocity.X;
                dust.velocity.Y = projectile.velocity.Y;
            }
        }
        
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
			for (int i = 0; i < 10; i++)
            {
				Dust dust = Dust.NewDustDirect(projectile.Center, projectile.width, projectile.height, 222);
				dust.noGravity = true;
				dust.scale = 0.7f;
                dust.velocity *= 10f;
            }                
            
            target.immune[projectile.owner] = 0;

            for(int i = 0; i < 1; i++)
            {
                Vector2 positionProj1 = new Vector2(target.Center.X - 500, target.Center.Y + Main.rand.Next(-500, 500));
                Vector2 velocityShoot = target.Center - positionProj1;
                float magnitude = Magnitude(velocityShoot);
                if(magnitude > 0)
                {
                    velocityShoot *= 30f / magnitude;
                } 
                else
                {
                    velocityShoot = new Vector2(0f, 10f);
                }            
                int FUCKINGSTORMHELL = Projectile.NewProjectile(positionProj1.X, positionProj1.Y, velocityShoot.X, velocityShoot.Y, 668, (int)damage / 2, 5, Main.myPlayer, 0f, 0f);
                Main.projectile[FUCKINGSTORMHELL].minion = false;
                Main.projectile[FUCKINGSTORMHELL].melee = true;
                Main.projectile[FUCKINGSTORMHELL].tileCollide = false;
                Main.projectile[FUCKINGSTORMHELL].timeLeft = 120;
            }
            for(int i = 0; i < 1; i++)
            {
                Vector2 positionProj2 = new Vector2(target.Center.X + 500, target.Center.Y + Main.rand.Next(-500, 500));
                Vector2 velocityShoot = target.Center - positionProj2;
                float magnitude = Magnitude(velocityShoot);
                if(magnitude > 0)
                {
                    velocityShoot *= 30f / magnitude;
                } 
                else
                {
                    velocityShoot = new Vector2(0f, 10f);
                }            
                int FUCKINGSTORMHELL = Projectile.NewProjectile(positionProj2.X, positionProj2.Y, velocityShoot.X, velocityShoot.Y, 668, (int)damage / 2, 0, Main.myPlayer, 0f, 0f);
                Main.projectile[FUCKINGSTORMHELL].minion = false;
                Main.projectile[FUCKINGSTORMHELL].melee = true;
                Main.projectile[FUCKINGSTORMHELL].tileCollide = false;
                Main.projectile[FUCKINGSTORMHELL].timeLeft = 120;
            }
        }
        private float Magnitude(Vector2 mag)
        {
            return (float)Math.Sqrt(mag.X * mag.X + mag.Y * mag.Y);
        }
        
    }
}