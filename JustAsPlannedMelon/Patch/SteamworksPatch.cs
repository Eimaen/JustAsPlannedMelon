using HarmonyLib;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustAsPlannedMelon.Patch
{
    [HarmonyPatch(typeof(SteamApps), "GetEarliestPurchaseUnixTime", new Type[] { typeof(AppId_t) })]
    public static class HkGetEarliestPurchaseUnixTime
    {
        private static void Postfix(out uint __result) => __result = (uint)DateTimeOffset.UtcNow.ToUnixTimeSeconds();
    }

    [HarmonyPatch(typeof(SteamApps), "BIsDlcInstalled", new Type[] { typeof(AppId_t) })]
    public static class HkBIsDlcInstalled
    {
        private static void Postfix(AppId_t appID, out bool __result) => __result = true;
    }
}
