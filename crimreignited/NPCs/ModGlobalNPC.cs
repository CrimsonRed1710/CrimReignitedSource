using System.IO;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using Terraria.ModLoader.IO;
using Terraria.DataStructures;
using Microsoft.Xna.Framework.Graphics;

namespace crimreignited.NPCs
{
    public class ModGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {   
            if (npc.type == 250) //nimbus
            {
                if (Main.rand.Next(39) == 0) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("volt"), 1);
                }
            }
			
            if (npc.type == 439)  //lunatic cultist
            {
                if (Main.rand.Next(3) == 0) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("polaris"), 1);
                }
            }
			
			if (npc.type == 62)  //demon
            {
                if (Main.rand.Next(5) == 0) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("hellfire_shard"), 1);
                }
            }
			
			if (npc.type == 63)  //blue jellyfish
            {
                if (Main.rand.Next(50) == 0) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("rusty_magnum"), 1);
                }
            }
			
			if (npc.type == 64)  //pink jellyfish
            {
                if (Main.rand.Next(50) == 0) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("rusty_magnum"), 1);
                }
            }
			
			if (npc.type == 103)  //green jellyfish
            {
                if (Main.rand.Next(50) == 0) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("rusty_magnum"), 1);
                }
            }
			
			if (npc.type == 65)  //shark
            {
                if (Main.rand.Next(15) == 0) 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("tinted_scale"), 1);
                }
            }
        }
    }
}