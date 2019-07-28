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


namespace crimreignited
{
	public class crimworld : ModWorld
	{

		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
		{
			int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if (ShiniesIndex != -1)
			{
				tasks.Insert(ShiniesIndex + 1, new PassLegacy("Crystalizing Caverns", delegate (GenerationProgress progress)
				{
					progress.Message = "Crystalizing Caverns";

					for (int k = 0; k < (int)((double)(Main.maxTilesX * (Main.maxTilesY+(Main.maxTilesY/60))) * 6E-05); k++)
					{
						WorldGen.TileRunner(WorldGen.genRand.Next(0, Main.maxTilesX), WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY), (double)WorldGen.genRand.Next(3, 10), WorldGen.genRand.Next(4, 13), mod.TileType("vivianite"), false, 0f, 0f, false, true);
					}
				}));
			}
		}
	}
}
 