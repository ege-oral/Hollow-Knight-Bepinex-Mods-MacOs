using BepInEx;
using BepInEx.Unity.Mono;
using HarmonyLib;

namespace HollowKnightMods;

[BepInPlugin("ege.super.speed", "Super Speed Mod", "1.0.0")]
public class SuperSpeedMod : BaseUnityPlugin
{
    private void Awake()
    {
        Logger.LogInfo("Super Speed Mod Loaded!");
        var harmony = new Harmony("ege.super.speed");
        harmony.PatchAll();
    }
}

[HarmonyPatch(typeof(HeroController), "Move")]
public class SuperSpeedPatch
{
    static void Prefix(HeroController __instance)
    {
        __instance.RUN_SPEED = 15f;
        __instance.WALK_SPEED = 15f;
    }
}