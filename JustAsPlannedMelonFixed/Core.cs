using MelonLoader;
using HarmonyLib;
using Il2CppSteamworks;

[assembly: MelonInfo(typeof(JustAsPlannedMelonFixed.Core), "JustAsPlannedMelonFixed", "1.0.0", "Glitchtest51", null)]
[assembly: MelonGame("PeroPeroGames", "MuseDash")]

namespace JustAsPlannedMelonFixed {
    public class Core : MelonMod {
        public override void OnInitializeMelon() {
            LoggerInstance.Msg("Congratulations! You haven't paid for pixel Reimu.");
        }
    }
}

namespace JustAsPlannedMelon.Patch {
    [HarmonyPatch(typeof(SteamApps), "GetEarliestPurchaseUnixTime", new Type[] { typeof(AppId_t) })]
    public static class HkGetEarliestPurchaseUnixTime {
        private static void Postfix(out uint __result) => __result = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds();
    }

    [HarmonyPatch(typeof(SteamApps), "BIsDlcInstalled", new Type[] { typeof(AppId_t) })]
    public static class HkBIsDlcInstalled {
        private static void Postfix(AppId_t appID, out bool __result) => __result = true;
    }
}