using BepInEx;
using BepInEx.Unity.Mono;
using HarmonyLib;

namespace HollowKnightMods;

[BepInPlugin("ege.infinite.jumps", "Infinite Jumps Mod", "1.0.0")]
public class InfiniteJumpsMod : BaseUnityPlugin
{
    private void Awake()
    {
        Logger.LogInfo("Infinite Jumps Mod Loaded!");
        var harmony = new Harmony("ege.infinite.jumps");
        harmony.PatchAll();
    }
}

[HarmonyPatch(typeof(HeroController), "CanJump")]
public class InfiniteJumpsPatch
{
    static void Postfix(ref bool __result)
    {
        if (__result == false)
        {
            __result = true;
        }
    }
}