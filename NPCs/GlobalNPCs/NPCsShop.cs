using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftablePrismaticLacewing.NPCs.GlobalNPCs
{
    class NpcsShop:GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot) 
        {
            if(type==NPCID.BestiaryGirl)
            {
                shop.item[nextSlot].SetDefaults(ItemID.TreeNymphButterfly);
                nextSlot++;
            }
        }
    }
}