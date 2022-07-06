using Terraria;
using Terraria.ModLoader;
using CraftablePrismaticLacewing.NPCs;

namespace CraftablePrismaticLacewing.Content.Buffs
{
	///peasebuff
    public class UltimatePeaseBuff : ModBuff
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Very Quiet");
			Description.SetDefault("No Enermy will Spawn");
			Main.buffNoSave[Type]=true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			//player.statDefense-=5;
			player.buffTime[buffIndex] = 10;
			player.GetModPlayer<PlayerEnermySpawn>().EnermyOn=2;
	    }
    }
}
