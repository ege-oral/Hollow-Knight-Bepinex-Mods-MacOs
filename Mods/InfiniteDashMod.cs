using BepInEx;
using BepInEx.Unity.Mono;
using HarmonyLib;

namespace HollowKnightMods;

[BepInPlugin("ege.infinite.dash", "Infinite Jumps Mod", "1.0.0")]
public class InfiniteDashMod : BaseUnityPlugin
{
    private void Awake()
    {
        Logger.LogInfo("Infinite Dash Mod Loaded!");
        var harmony = new Harmony("ege.infinite.dash");
        harmony.PatchAll();
    }
}

[HarmonyPatch(typeof(HeroController), "CanDash")]
public class InfiniteDashesPatch
{
    static void Postfix(ref bool __result)
    {
        if (__result == false)
        {
            __result = true;
        }
    }
}