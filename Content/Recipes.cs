using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static CraftablePrismaticLacewing.Content.Recipegroups;

namespace CraftablePrismaticLacewing.Content
{
    public class Recipes : ModSystem
    {
        public override void AddRecipes()
        {
            /////////summons/////////
            ///preHardMode///
            //////GuideVoodooDoll
            Recipe GuideVoodooDollCr = Recipe.Create(ItemID.GuideVoodooDoll, 1);
            GuideVoodooDollCr.AddIngredient(ItemID.Silk, 15);
            GuideVoodooDollCr.AddRecipeGroup(Evilbar, 10);
            GuideVoodooDollCr.AddTile(TileID.DemonAltar);
            GuideVoodooDollCr.Register();
            ///afterHardMode///
            //////EmpressButterfly
            Recipe EmpressButterflyCr = Recipe.Create(ItemID.EmpressButterfly, 1);
            //EmpressButterflyCr.AddIngredient(ItemID.ButterflyDust,1);
            EmpressButterflyCr.AddIngredient(ItemID.SoulofLight, 15);
            EmpressButterflyCr.AddIngredient(ItemID.SilverDye, 7);
            EmpressButterflyCr.AddRecipeGroup(RecipeGroupID.Butterflies, 1);
            EmpressButterflyCr.AddCondition(Recipe.Condition.InHallow);
            EmpressButterflyCr.Register();
            //////QueenSlimeCrystal
            Recipe QueenSlimeCrystalCr = Recipe.Create(ItemID.QueenSlimeCrystal, 1);
            QueenSlimeCrystalCr.AddIngredient(ItemID.CrystalShard, 1);
            QueenSlimeCrystalCr.AddIngredient(ItemID.Gel, 30);
            QueenSlimeCrystalCr.AddCondition(Recipe.Condition.InHallow);
            QueenSlimeCrystalCr.Register();
            //////TruffleWorm
            Recipe TruffleWormCr = Recipe.Create(ItemID.TruffleWorm, 1);
            TruffleWormCr.AddIngredient(ItemID.Worm);
            TruffleWormCr.AddIngredient(ItemID.MushroomGrassSeeds);
            TruffleWormCr.AddTile(TileID.Bottles);
            TruffleWormCr.AddCondition(Recipe.Condition.InGlowshroom);
            TruffleWormCr.Register();
            //////bloodtear
            Recipe BloodTearCr=Recipe.Create(ItemID.BloodMoonStarter);
            BloodTearCr.AddRecipeGroup(AnyVertebrae,10);
            BloodTearCr.AddTile(TileID.Bottles);
            BloodTearCr.Register();

            /////////weapon/////////
            //////Terraprisma
            Recipe TerraprismaCr =Recipe.Create(ItemID.EmpressBlade);
            TerraprismaCr.AddIngredient(ItemID.CrystalShard, 10);
            TerraprismaCr.AddIngredient(ItemID.FragmentStardust,10);
            TerraprismaCr.AddIngredient(ItemID.SoulofLight, 20);
            TerraprismaCr.AddRecipeGroup(AnyLightEmpressWeapon, 3);
            TerraprismaCr.AddTile(TileID.MythrilAnvil);
            TerraprismaCr.Register();

            /////////accessories/////////
            //////WhoopieCushion
            Recipe WhoopieCushionCr =Recipe.Create(ItemID.WhoopieCushion, 1);
            WhoopieCushionCr.AddRecipeGroup(AnyVertebrae, 15);
            WhoopieCushionCr.AddIngredient(ItemID.Silk, 5);
            WhoopieCushionCr.AddTile(TileID.Anvils);
            //WhoopieCushionCr.AddCondition(Recipe.Condition.InGraveyardBiome);
            WhoopieCushionCr.Register();
            //////POcketMirror
            Recipe PocketMirrorCr = Recipe.Create(ItemID.PocketMirror);
            PocketMirrorCr.AddIngredient(ItemID.Glass,20);
            PocketMirrorCr.AddIngredient(ItemID.SoulofLight,3);
            PocketMirrorCr.AddTile(TileID.MythrilAnvil);
            PocketMirrorCr.Register();
            //////LavafishingHook
            Recipe LavaFishingHookCr=Recipe.Create(ItemID.LavaFishingHook);
            LavaFishingHookCr.AddIngredient(ItemID.Obsidian,3);
            LavaFishingHookCr.AddTile(TileID.Hellforge);
            LavaFishingHookCr.Register();

            /////////Tools/////////
            //////GoldenFishingRod
            Recipe GoldenFishingRodCr = Recipe.Create(ItemID.GoldenFishingRod, 1);
            GoldenFishingRodCr.AddRecipeGroup(AnyGoldbar, 15);
            GoldenFishingRodCr.AddIngredient(ItemID.WhiteString);
            GoldenFishingRodCr.AddTile(TileID.Anvils);
            //GoldenFishingRodCr.AddCondition(Recipe.Condition.NearWater);
            GoldenFishingRodCr.Register();
            //////Picksaw
            Recipe PicksawCr = Recipe.Create(ItemID.Picksaw);
            PicksawCr.AddIngredient(ItemID.LunarTabletFragment,12);
            PicksawCr.AddIngredient(ItemID.BeetleHusk);
            PicksawCr.AddTile(TileID.MythrilAnvil);
            PicksawCr.Register();

            /////////Mounts/////////
            //////BrainScrambler
            Recipe BrainScramblerCr = Recipe.Create(ItemID.BrainScrambler);
            BrainScramblerCr.AddIngredient(ItemID.MartianConduitPlating, 60);
            BrainScramblerCr.AddIngredient(ItemID.ShroomiteBar, 10);
            BrainScramblerCr.AddTile(TileID.MythrilAnvil);
            BrainScramblerCr.Register();

            /////////Special/////////
            //////GoldenKey
            Recipe GoldenKeyCr =Recipe.Create(ItemID.GoldenKey);
            GoldenKeyCr.AddRecipeGroup(AnyGoldbar,1);
            GoldenKeyCr.AddIngredient(ItemID.Gel, 10);
            GoldenKeyCr.AddCondition(Recipe.Condition.InDungeon);
            GoldenKeyCr.Register();
            //////ShadowKey
            Recipe ShadowKeyCr = Recipe.Create(ItemID.ShadowKey);
            ShadowKeyCr.AddIngredient(ItemID.Obsidian,1);
            ShadowKeyCr.AddRecipeGroup(AnyVertebrae,5);
            ShadowKeyCr.AddIngredient(ItemID.Bone,10);
            ShadowKeyCr.AddTile(TileID.Anvils);
            ShadowKeyCr.Register();

            /////////furniture/////////
            //////Extractinator
            Recipe ExtractinatorCr = Recipe.Create(ItemID.Extractinator, 1);
            ExtractinatorCr.AddRecipeGroup(RecipeGroupID.IronBar, 50);
            ExtractinatorCr.AddIngredient(ItemID.Silk, 10);
            ExtractinatorCr.AddTile(TileID.Anvils);
            ExtractinatorCr.Register();

            /////////material/////////
            ///preHardMode///
            //////Meteoritebar
            Recipe MeteoriteBarCr=Recipe.Create(ItemID.MeteoriteBar,3);
            MeteoriteBarCr.AddIngredient(ItemID.FallenStar,5);
            MeteoriteBarCr.AddRecipeGroup(RecipeGroupID.IronBar,3);
            //MeteoriteBarCr.AddIngredient(ItemID.TissueSample,3);
            MeteoriteBarCr.AddRecipeGroup(AnyTissueSample,3);
            MeteoriteBarCr.AddTile(TileID.Hellforge);
            MeteoriteBarCr.Register();
            //////Hay
            Recipe HayCr =Recipe.Create(ItemID.Hay);
            HayCr.AddIngredient(ItemID.Rope,2);
            HayCr.AddTile(TileID.Tables);
            HayCr.Register();
            

            ///afterHardMode///
            //////SoulofLIght
            Recipe SoulofLightCr = Recipe.Create(ItemID.SoulofLight, 2);
            SoulofLightCr.AddIngredient(ItemID.CrystalShard, 1);
            SoulofLightCr.AddTile(TileID.DemonAltar);
            SoulofLightCr.Register();
            //////CrystalShard
            Recipe CrystalShardCr = Recipe.Create(ItemID.CrystalShard, 1);
            CrystalShardCr.AddIngredient(ItemID.SoulofLight, 1);
            //CrystalShardCr.AddIngredient(ItemID.StoneBlock, 20);
            CrystalShardCr.AddRecipeGroup(AnyHallowBlock, 3);
            CrystalShardCr.AddTile(TileID.DemonAltar);
            CrystalShardCr.Register();
            //////SoulofNight
            Recipe SoulofNightCr = Recipe.Create(ItemID.SoulofNight, 2);
            SoulofNightCr.AddRecipeGroup(AnyIchor, 1);
            SoulofNightCr.AddTile(TileID.DemonAltar);
            SoulofNightCr.Register();
            //////Ichor
            Recipe IchorCr = Recipe.Create(ItemID.Ichor, 1);
            IchorCr.AddIngredient(ItemID.SoulofNight, 1);
            IchorCr.AddRecipeGroup(AnyCrimsonBlock, 3);
            IchorCr.Register();
            //////CursedFlame
            Recipe CursedFlameCr = Recipe.Create(ItemID.CursedFlame, 1);
            CursedFlameCr.AddIngredient(ItemID.SoulofNight);
            CursedFlameCr.AddRecipeGroup(AnyCorruptionBlock, 3);
            CursedFlameCr.Register();
            //////LifeFruit
            Recipe LifeFruitCr = Recipe.Create(ItemID.LifeFruit, 1);
            LifeFruitCr.AddIngredient(ItemID.LifeCrystal, 1);
            //LifeFruitCr.AddIngredient(ItemID.SoulofFright, 3);
            LifeFruitCr.AddRecipeGroup(AnyIronBossSoul, 3);
            LifeFruitCr.AddTile(TileID.CrystalBall);
            LifeFruitCr.Register();
            //////MasterBait
            Recipe MasterBaitCr = Recipe.Create(ItemID.MasterBait);
            MasterBaitCr.AddIngredient(ItemID.Bass, 1);
            MasterBaitCr.AddIngredient(ItemID.Acorn,1);
            MasterBaitCr.AddTile(TileID.Bottles);
            MasterBaitCr.Register();
            //////MushroomGrassSeeds
            Recipe MushroomGrassSeedsCr =Recipe.Create(ItemID.MushroomGrassSeeds,3);
            MushroomGrassSeedsCr.AddIngredient(ItemID.GlowingMushroom, 1);
            MushroomGrassSeedsCr.AddTile(TileID.Bottles);
            MushroomGrassSeedsCr.AddCondition(Recipe.Condition.InGlowshroom);
            MushroomGrassSeedsCr.Register();
        }
    }
}
