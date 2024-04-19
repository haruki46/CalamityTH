
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace CalamityTH
{

    public class CalamityTH : Mod
    {
        public static Mod Instance
        {
            get;
            private set;
        }

        public override void Load()
        {
            Instance = this;
            if (Main.netMode != NetmodeID.Server)
            {
                var calamityMod = ModLoader.GetMod("CalamityMod");
                var ThaiLanguage = ModLoader.GetMod("ThaiLanguageLibrary");
                Main.QueueMainThreadAction(() =>
                {
                    calamityMod.Call("LoadParticleInstances", this);
                    ThaiLanguage.Call("LoadThaiLanguage", this);
                });
            }
        }
    }
}