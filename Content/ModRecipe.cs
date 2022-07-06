using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static CraftablePrismaticLacewing.Content.Recipegroups;

namespace CraftablePrismaticLacewing.Content
{
    public class ModRecipe:ModSystem
    {
        public override void AddRecipes()
        {
            Recipe UltimateBattlePotionCr=Recipe.Create(ModContent.ItemType<Potion.UltimateBattlePotion>());
            UltimateBattlePotionCr.AddRecipeGroup(AnyVertebrae,30);
            UltimateBattlePotionCr.AddIngredient(ItemID.BottledWater,3);
            UltimateBattlePotionCr.AddIngredient(ItemID.Deathweed,15);
            UltimateBattlePotionCr.AddRecipeGroup(AnyIchor,20);
            UltimateBattlePotionCr.AddIngredient(ItemID.BattlePotion,20);
            UltimateBattlePotionCr.AddIngredient(ItemID.IronskinPotion,4);
            UltimateBattlePotionCr.AddTile(TileID.Bottles);
            UltimateBattlePotionCr.Register();
            //UltimateBattlePotionCR.AddCondition(Recipe.Condition.InCorrupt);
            Recipe UltimatePeasePotionCr=Recipe.Create(ModContent.ItemType<Potion.UltimatePeasePotion>(),1);
            UltimatePeasePotionCr.AddIngredient(ItemID.BottledWater,3);
            UltimatePeasePotionCr.AddIngredient(ItemID.Sunflower);
            UltimatePeasePotionCr.AddIngredient(ItemID.Daybloom,9);
            UltimatePeasePotionCr.AddRecipeGroup(AnyHallowBlock,20);
            UltimatePeasePotionCr.AddIngredient(ItemID.SoulofLight,10);
            UltimatePeasePotionCr.AddTile(TileID.Bottles);
            UltimatePeasePotionCr.Register();
        }

    }
}