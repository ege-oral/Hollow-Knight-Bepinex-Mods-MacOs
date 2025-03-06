using BepInEx;
using BepInEx.Unity.Mono;
using HarmonyLib;

namespace HollowKnightMods;

[BepInPlugin("ege.no.damage", "No Damage Mod", "1.0.0")]
public class NoDamageMod : BaseUnityPlugin
{
    private void Awake()
    {
        Logger.LogInfo("No Damage Mod Loaded!");
        var harmony = new Harmony("ege.no.damage");
        harmony.PatchAll();
    }
}

[HarmonyPatch(typeof(HeroController), "TakeDamage")]
public class NoDamagePatch
{
    static bool Prefix() => false;
}