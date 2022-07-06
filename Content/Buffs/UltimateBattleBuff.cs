using Terraria;
using Terraria.ModLoader;
using CraftablePrismaticLacewing.NPCs;

namespace CraftablePrismaticLacewing.Content.Buffs
{
	///peasebuff
    public class UltimateBattleBuff : ModBuff
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("This will be hard time");
			Description.SetDefault("Enermy spawning increase to a large scale");
			Main.buffNoSave[Type]=true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) 
		{
			player.statDefense+=20;
			player.buffTime[buffIndex] = 10;
			player.GetModPlayer<PlayerEnermySpawn>().EnermyOn=1;
	    }
    }
}