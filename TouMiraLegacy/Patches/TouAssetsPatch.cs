using HarmonyLib;
using MiraAPI.Utilities.Assets;
using TouMiraLegacy.Assets;
using TownOfUs.Assets;
using UnityEngine;

namespace TouMiraLegacy.Patches;

[HarmonyPatch]
public static class TouAssetsPatch
{
    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.KillSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool KillSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyVanillaAssets.KillSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.AbilityCounterBasicSprite), MethodType.Getter)]
    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.AbilityCounterBodySprite), MethodType.Getter)]
    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.AbilityCounterPlayerSprite), MethodType.Getter)]
    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.AbilityCounterVentSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool AbilityCounter(ref LoadableAsset<Sprite> __result)
    {
        __result = TouAssets.BlankSprite;
        return false;
    }
    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.Banner), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool Banner(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyAssets.Banner;
        return false;
    }

    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.BroadcastSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool BroadcastSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyAssets.BroadcastSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.DisperseSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool DisperseSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyAssets.DisperseSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.HysteriaSprite), MethodType.Getter)]
    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.HysteriaCleanSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool HysteriaSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyAssets.HysteriaSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.BlackmailLetterSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool BlackmailLetterSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyAssets.BlackmailLetterSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.BlackmailOverlaySprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool BlackmailOverlaySprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyAssets.BlackmailOverlaySprite;
        return false;
    }

    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.SwapActive), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool SwapActive(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyAssets.SwapActive;
        return false;
    }

    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.SwapInactive), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool SwapInactive(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyAssets.SwapInactive;
        return false;
    }

    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.RevealButtonSprite), MethodType.Getter)]
    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.RevealCleanSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool RevealButtonSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyAssets.RevealButtonSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.JailCellSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool JailCellSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyAssets.JailCellSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.ImitateSelectSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool ImitateSelectSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyAssets.ImitateSelectSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.ImitateDeselectSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool ImitateDeselectSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyAssets.ImitateDeselectSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.ExecuteSprite), MethodType.Getter)]
    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.ExecuteCleanSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool ExecuteSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyAssets.ExecuteSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.Hacked), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool Hacked(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyAssets.Hacked;
        return false;
    }

    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.BarricadeVentSprite), MethodType.Getter)]
    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.BarricadeVentSprite2), MethodType.Getter)]
    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.BarricadeVentSprite3), MethodType.Getter)]
    [HarmonyPatch(typeof(TouAssets), nameof(TouAssets.BarricadeFungleSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool BarricadeVentSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyAssets.BarricadeVentSprite;
        return false;
    }

}