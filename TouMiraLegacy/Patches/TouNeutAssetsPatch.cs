using HarmonyLib;
using MiraAPI.Utilities.Assets;
using TouMiraLegacy.Assets;
using TownOfUs.Assets;
using UnityEngine;

namespace TouMiraLegacy.Patches;

[HarmonyPatch]
public static class TouNeutAssetsPatch
{
    [HarmonyPatch(typeof(TouNeutAssets), nameof(TouNeutAssets.GlitchKillSprite), MethodType.Getter)]
    [HarmonyPatch(typeof(TouNeutAssets), nameof(TouNeutAssets.InquisKillSprite), MethodType.Getter)]
    [HarmonyPatch(typeof(TouNeutAssets), nameof(TouNeutAssets.JuggKillSprite), MethodType.Getter)]
    [HarmonyPatch(typeof(TouNeutAssets), nameof(TouNeutAssets.PestKillSprite), MethodType.Getter)]
    [HarmonyPatch(typeof(TouNeutAssets), nameof(TouNeutAssets.WerewolfKillSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool KillSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyVanillaAssets.KillSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouNeutAssets), nameof(TouNeutAssets.RememberButtonSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool RememberButtonSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyNeutAssets.RememberButtonSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouNeutAssets), nameof(TouNeutAssets.ProtectSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool ProtectSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyNeutAssets.ProtectSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouNeutAssets), nameof(TouNeutAssets.GuardSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool GuardSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyNeutAssets.GuardSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouNeutAssets), nameof(TouNeutAssets.BribeSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool BribeSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyNeutAssets.BribeSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouNeutAssets), nameof(TouNeutAssets.VestSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool VestSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyNeutAssets.VestSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouNeutAssets), nameof(TouNeutAssets.Observe), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool Observe(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyNeutAssets.Observe;
        return false;
    }

    [HarmonyPatch(typeof(TouNeutAssets), nameof(TouNeutAssets.DouseButtonSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool DouseButtonSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyNeutAssets.DouseButtonSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouNeutAssets), nameof(TouNeutAssets.IgniteButtonSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool IgniteButtonSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyNeutAssets.IgniteButtonSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouNeutAssets), nameof(TouNeutAssets.HackSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool HackSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyNeutAssets.HackSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouNeutAssets), nameof(TouNeutAssets.MimicSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool MimicSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyNeutAssets.MimicSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouNeutAssets), nameof(TouNeutAssets.InfectSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool InfectSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyNeutAssets.InfectSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouNeutAssets), nameof(TouNeutAssets.ReapSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool ReapSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyNeutAssets.ReapSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouNeutAssets), nameof(TouNeutAssets.BiteSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool BiteSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyNeutAssets.BiteSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouNeutAssets), nameof(TouNeutAssets.RampageSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool RampageSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyNeutAssets.RampageSprite;
        return false;
    }

}