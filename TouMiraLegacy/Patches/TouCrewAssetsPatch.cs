using HarmonyLib;
using MiraAPI.Utilities.Assets;
using TouMiraLegacy.Assets;
using TownOfUs.Assets;
using UnityEngine;

namespace TouMiraLegacy.Patches;

[HarmonyPatch]
public static class TouCrewAssetsPatch
{
    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.HunterKillSprite), MethodType.Getter)]
    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.SheriffShootSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool KillSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyVanillaAssets.KillSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.EngiVentSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool VentSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyVanillaAssets.VentSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.InspectSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool InspectSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.InspectSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.ExamineSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool ExamineSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.ExamineSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.WatchSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool WatchSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.WatchSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.ConfessSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool ConfessSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.ConfessSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.BlessSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool BlessSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.BlessSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.SeerSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool SeerSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.SeerSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.TrackSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool TrackSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.TrackSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.TrapSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool TrapSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.TrapSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.CampButtonSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool CampButtonSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.CampButtonSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.StalkButtonSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool StalkButtonSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.StalkButtonSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.JailSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool JailSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.JailSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.AlertSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool AlertSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.AlertSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.ReviveSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool ReviveSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.ReviveSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.CleanseSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool CleanseSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.CleanseSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.BarrierSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool BarrierSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.BarrierSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.MedicSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool MedicSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.MedicSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.FortifySprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool FortifySprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.FortifySprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.FixButtonSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool FixButtonSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.FixButtonSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.MediateSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool MediateSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.MediateSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.CampaignButtonSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool CampaignButtonSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.CampaignButtonSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.FlushSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool FlushSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.FlushSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.BlockSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool BlockSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.BlockSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.RewindSprite), MethodType.Getter)]
    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.RewindingSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool RewindSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.RewindSprite;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.Transport), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool Transport(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.Transport;
        return false;
    }

    [HarmonyPatch(typeof(TouCrewAssets), nameof(TouCrewAssets.DeployCamSprite), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool DeployCamSprite(ref LoadableAsset<Sprite> __result)
    {
        __result = LegacyCrewAssets.DeployCamSprite;
        return false;
    }

}