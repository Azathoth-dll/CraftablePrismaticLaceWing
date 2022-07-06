using Terraria;
using Terraria.ModLoader;
using static CraftablePrismaticLacewing.Content.Buffs.UltimateBattleBuff;
using static CraftablePrismaticLacewing.Content.Buffs.UltimatePeaseBuff;

namespace CraftablePrismaticLacewing.NPCs
{
	public class PlayerEnermySpawn:ModPlayer
	{
		public int EnermyOn;
		public override void ResetEffects() 
		{
			EnermyOn = 2;
		}
	}
	public class EnermySpawn:GlobalNPC
	{
		public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
		{
			if(player.GetModPlayer<PlayerEnermySpawn>().EnermyOn==1)
			{
				spawnRate=0;
				maxSpawns=1;
				//spawnRate=-2*spawnRate;spawnrate must be >= 0
				maxSpawns=100*maxSpawns;
			}
            else if(player.GetModPlayer<PlayerEnermySpawn>().EnermyOn==0)
            {
                spawnRate=99;
				maxSpawns=-1;
				spawnRate=spawnRate*99;
                maxSpawns=maxSpawns*99;
            }

		}
	}
}
