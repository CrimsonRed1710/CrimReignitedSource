using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace crimreignited.Tiles
{
	public class vivianite : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSpelunker[Type] = false;
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			minPick = 65;
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Vivianite");
			drop = mod.ItemType("vivianite");
			AddMapEntry(new Color(130, 224, 170), name);
		}


		public override bool CanExplode(int i, int j)
		{
		if (Main.tile[i, j].type == mod.TileType("vivianite"))
		{
			return false;
		}
		return false;
		}	

	
	}
}