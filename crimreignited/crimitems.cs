using System.IO;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace crimitems
{
	public class crimitems: GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.Chain)
            {
                item.ammo = ItemID.Chain;
                item.maxStack = 999;
            }
        }
    }

}
