using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CraftablePrismaticLacewing.Content
{
    public class Recipegroups : ModSystem
    {
        //////public RecipeGroup
        public static RecipeGroup Evilbar;
        public static RecipeGroup AnyVertebrae;
        public static RecipeGroup AnyIchor;
        public static RecipeGroup AnyHallowBlock;
        public static RecipeGroup AnyCrimsonBlock;
        public static RecipeGroup AnyCorruptionBlock;
        public static RecipeGroup AnyIronBossSoul;
        public static RecipeGroup AnyLightEmpressWeapon;
        public static RecipeGroup AnyGoldbar;
        public static RecipeGroup AnyTissueSample;
        //////Unload RecipeGroup
        public override void Unload()
        {
            Evilbar = null;
            AnyVertebrae = null;
            AnyIchor = null;
            AnyHallowBlock = null;
            AnyCrimsonBlock = null;
            AnyCorruptionBlock = null;
            AnyIronBossSoul = null;
            AnyLightEmpressWeapon = null;
            AnyGoldbar = null;
            AnyTissueSample=null;
        }
        //////define Group
        public override void AddRecipeGroups()
        {
            Evilbar = new RecipeGroup(() => $"Any Evil Bar", ItemID.CrimtaneBar, ItemID.DemoniteBar);
            AnyVertebrae = new RecipeGroup(() => $"Any Vertebrae", ItemID.Vertebrae, ItemID.RottenChunk);
            AnyIchor = new RecipeGroup(() => $"Any Ichor", ItemID.Ichor, ItemID.CursedFlame);
            AnyHallowBlock = new RecipeGroup(() => $"Any Hallow Block", ItemID.PearlsandBlock, ItemID.PearlstoneBlock, ItemID.HallowHardenedSand, ItemID.HallowSandstone, ItemID.PinkIceBlock);
            AnyCrimsonBlock = new RecipeGroup(() => $"Any Crimson Block", ItemID.CrimsandBlock, ItemID.CrimsonSandstone, ItemID.CrimstoneBlock, ItemID.CrimsonHardenedSand, ItemID.RedIceBlock);
            AnyCorruptionBlock = new RecipeGroup(() => $"Any Corruption Block", ItemID.CorruptHardenedSand, ItemID.CorruptSandstone, ItemID.EbonsandBlock, ItemID.PurpleIceBlock, ItemID.EbonstoneBlock);
            AnyIronBossSoul = new RecipeGroup(() => $"Any Iron Boss Soul", ItemID.SoulofFright, ItemID.SoulofMight, ItemID.SoulofSight);
            //AnyLightEmpressWeapon = new RecipeGroup(() => $"Any LightEmpress Weapon");
            AnyLightEmpressWeapon = new RecipeGroup(() => $"Any Light Empress Weapon", ItemID.FairyQueenMagicItem, ItemID.FairyQueenRangedItem, ItemID.PiercingStarlight, ItemID.RainbowWhip);
            AnyGoldbar = new RecipeGroup(() => $"Any Gold bar", ItemID.GoldBar, ItemID.PlatinumBar);
            AnyTissueSample=new RecipeGroup(()=>$"Any Tissue Sample",ItemID.TissueSample,ItemID.ShadowScale);
            //////register Group
            RecipeGroup.RegisterGroup("Evilbar", Evilbar);
            RecipeGroup.RegisterGroup("AnyVertebrae", AnyVertebrae);
            RecipeGroup.RegisterGroup("AnyIchor", AnyIchor);
            RecipeGroup.RegisterGroup("AnyHallowBlock", AnyHallowBlock);
            RecipeGroup.RegisterGroup("AnyCrimsonBlock", AnyCrimsonBlock);
            RecipeGroup.RegisterGroup("AnyIronBossSoul", AnyIronBossSoul);
            RecipeGroup.RegisterGroup("AnyLightEmpressWeapon", AnyLightEmpressWeapon);
            RecipeGroup.RegisterGroup("AnyGoldbar", AnyGoldbar);
            RecipeGroup.RegisterGroup("AnyTissueSample",AnyTissueSample);
        }
    }
}