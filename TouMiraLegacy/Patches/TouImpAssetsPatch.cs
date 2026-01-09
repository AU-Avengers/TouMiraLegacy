using HarmonyLib;
using MiraAPI.Utilities.Assets;
using TouMiraLegacy.Assets;
using TownOfUs.Assets;
using UnityEngine;

namespace TouMiraLegacy.Patches;

[HarmonyPatch]
public static class TouImpAssetsPatch
{
    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.MarkSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool MarkSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyImpAssets.MarkSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.RecallSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool RecallSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyImpAssets.RecallSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.FlashSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool FlashSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyImpAssets.FlashSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.BlindSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool BlindSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyImpAssets.BlindSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.SampleSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool SampleSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyImpAssets.SampleSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.MorphSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool MorphSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyImpAssets.MorphSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.SwoopSprite), MethodType.Getter)]
    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.UnswoopSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool SwoopSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyImpAssets.SwoopSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.NoAbilitySprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool NoAbilitySprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyImpAssets.NoAbilitySprite;
        return false;
    }

    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.CamouflageSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool CamouflageSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyImpAssets.CamouflageSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.SprintSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool SprintSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyImpAssets.SprintSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.FreezeSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool FreezeSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyImpAssets.FreezeSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.PlaceSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool PlaceSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyImpAssets.PlantSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.DetonatingSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool DetonatingSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyImpAssets.DetonatingSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.BlackmailSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool BlackmailSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyImpAssets.BlackmailSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.HypnotiseButtonSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool HypnotiseButtonSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyImpAssets.HypnotiseButtonSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.CleanButtonSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool CleanButtonSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyImpAssets.CleanButtonSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.MineSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool MineSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyImpAssets.MineSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.DragSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool DragSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyImpAssets.DragSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouImpAssets), nameof(TouImpAssets.DropSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool DropSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyImpAssets.DropSprite;
        return false;
    }

}