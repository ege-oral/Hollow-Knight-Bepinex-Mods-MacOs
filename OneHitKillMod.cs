using BepInEx;
using BepInEx.Unity.Mono;
using HarmonyLib;

namespace HollowKnightMods;

[BepInPlugin("ege.one.hit.kill", "One-Hit Kill Mod", "1.0.0")]
public class OneHitKillMod : BaseUnityPlugin
{
    private void Awake()
    {
        Logger.LogInfo("One-Hit Kill Mod Loaded!");
        var harmony = new Harmony("ege.one.hit.kill");
        harmony.PatchAll();
    }
}

[HarmonyPatch(typeof(GetNailDamage), "OnEnter")]
public class OneHitKillPatch
{
    static void Postfix(ref GetNailDamage __instance)
    {
        __instance.storeValue.Value = 9999;
    }
}