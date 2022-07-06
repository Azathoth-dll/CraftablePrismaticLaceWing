using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace CraftablePrismaticLacewing.Content.Potion
{
	public class UltimatePeasePotion : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Pease and Quiet.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;			
		}

		public override void SetDefaults() {
			Item.width = 20;
			Item.height = 26;
			Item.useStyle = ItemUseStyleID.DrinkLiquid;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useTurn = true;
			Item.UseSound = SoundID.Item3;
			Item.maxStack = 1;
			Item.consumable = false;
			Item.rare = ItemRarityID.Orange;
			Item.potion=false;
			Item.value = Item.buyPrice(gold: 1);
			Item.buffType = ModContent.BuffType<Buffs.UltimatePeaseBuff>(); 
			Item.buffTime = 5400; 
		}
	}
}