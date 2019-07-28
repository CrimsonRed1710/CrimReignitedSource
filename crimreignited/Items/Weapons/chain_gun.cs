using Terraria;
using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace crimreignited.Items.Weapons
{
    public class chain_gun: ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chain Gun");
			Tooltip.SetDefault("'Fires chains that latch onto enemies");
		}

        public override void SetDefaults()
        {
            item.damage = 30;
            item.noMelee = true;
            item.ranged = true;
            item.width = 46;
            item.height = 30;
            item.useTime = 10;
            item.useAnimation = 9;
            item.useStyle = 5;
            item.shoot = mod.ProjectileType ("chain");
            item.useAmmo = ItemID.Chain;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.rare = 10;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shootSpeed = 20f;

        }
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-3, 0);
		}          
    }
}