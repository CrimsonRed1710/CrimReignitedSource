using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;         
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace crimreignited.Items.Weapons
{
    public class failures_throw : ModItem 
    {
        public override void SetStaticDefaults()
		{

			DisplayName.SetDefault("Failure's Throw");
			Tooltip.SetDefault("'I see you using cheat sheet or hero's mod, this is wip stuff :P'");

		}
        public override void SetDefaults()
        {

            item.damage = 1800;//The damage stat for the Weapon.
            item.melee = true;     //This defines if it does Melee damage and if its effected by Melee increasing Armor/Accessories.
            item.useTime = 10;  //How fast the Weapon is used.
            item.useAnimation = 10;   //How long the Weapon is used for.
            item.scale = 1.2f;
            item.expert = true;
            item.useStyle = 5;//The way your Weapon will be used, 1 is the regular sword swing for example
            item.channel = true;// We can keep the left mouse button down when trying to keep using this weapon.
            item.knockBack = 2f;//The knockback stat of your Weapon.
            item.rare = 11;//The color the title of your Weapon when hovering over it ingame   
            item.autoReuse = true;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.shoot = mod.ProjectileType("failuresThrowProj"); //This defines what type of projectile this weapon will shot	
            item.shootSpeed = 30f;         
            item.noUseGraphic = true; //  Do not use the item graphic when using the item (we just want the yoyo projectile to spawn).
            item.noMelee = true;// Makes sure that the animation when using the item doesn't hurt NPCs.
            item.UseSound = SoundID.Item1; //The sound played when using your Weapon

        }

        public override void AddRecipes()
        {

        }
        
    }
}