using HarmonyLib;
using MiraAPI.GameOptions;
using MiraAPI.Hud;
using TouMiraLegacy.Assets;
using TownOfUs.Buttons.Crewmate;
using TownOfUs.Buttons.Impostor;
using TownOfUs.Buttons.Modifiers;
using TownOfUs.Buttons.Neutral;

namespace TouMiraLegacy.Patches;

[HarmonyPatch]
public static class VanillaAssetsPatch
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Start))]
    [HarmonyPriority(Priority.Last)]
    [HarmonyPostfix]
    public static void PostLoadPatch(HudManager __instance)
    {
        var killBtn = __instance.KillButton;
        var reportBtn = __instance.ReportButton;
        var saboBtn = __instance.SabotageButton;
        var useBtn = __instance.UseButton;
        var ventBtn = __instance.ImpostorVentButton;
        killBtn.defaultKillSprite = LegacyVanillaAssets.KillSprite.LoadAsset();
        killBtn.graphic.sprite = LegacyVanillaAssets.KillSprite.LoadAsset();
        reportBtn.graphic.sprite = LegacyVanillaAssets.ReportSprite.LoadAsset();
        saboBtn.graphic.sprite = LegacyVanillaAssets.SabotageSprite.LoadAsset();
        useBtn.graphic.sprite = LegacyVanillaAssets.UseSprite.LoadAsset();
        ventBtn.graphic.sprite = LegacyVanillaAssets.VentSprite.LoadAsset();
        killBtn.RemoveLabel();
        reportBtn.RemoveLabel();
        saboBtn.RemoveLabel();
        useBtn.RemoveLabel();
        ventBtn.RemoveLabel();
        CustomButtonSingleton<SatelliteButton>.Instance.RemoveLabel();
        CustomButtonSingleton<DisperseButton>.Instance.RemoveLabel();
        CustomButtonSingleton<BarryButton>.Instance.RemoveLabel();

        CustomButtonSingleton<HunterKillButton>.Instance.RemoveLabel();
        CustomButtonSingleton<SheriffShootButton>.Instance.RemoveLabel();
        CustomButtonSingleton<EngineerVentButton>.Instance.RemoveLabel();
        CustomButtonSingleton<DetectiveInspectButton>.Instance.RemoveLabel();
        CustomButtonSingleton<DetectiveExamineButton>.Instance.RemoveLabel();
        CustomButtonSingleton<WatchButton>.Instance.RemoveLabel();
        CustomButtonSingleton<OracleConfessButton>.Instance.RemoveLabel();
        CustomButtonSingleton<OracleBlessButton>.Instance.RemoveLabel();
        CustomButtonSingleton<SeerRevealButton>.Instance.RemoveLabel();
        CustomButtonSingleton<TrackerTrackButton>.Instance.RemoveLabel();
        CustomButtonSingleton<TrapperTrapButton>.Instance.RemoveLabel();
        CustomButtonSingleton<CampButton>.Instance.RemoveLabel();
        CustomButtonSingleton<HunterStalkButton>.Instance.RemoveLabel();
        CustomButtonSingleton<JailorJailButton>.Instance.RemoveLabel();
        CustomButtonSingleton<VeteranAlertButton>.Instance.RemoveLabel();
        CustomButtonSingleton<AltruistReviveButton>.Instance.RemoveLabel();
        CustomButtonSingleton<ClericCleanseButton>.Instance.RemoveLabel();
        CustomButtonSingleton<ClericBarrierButton>.Instance.RemoveLabel();
        CustomButtonSingleton<MedicShieldButton>.Instance.RemoveLabel();
        CustomButtonSingleton<WardenFortifyButton>.Instance.RemoveLabel();
        CustomButtonSingleton<EngineerFixButton>.Instance.RemoveLabel();
        CustomButtonSingleton<MediumMediateButton>.Instance.RemoveLabel();
        CustomButtonSingleton<PoliticianCampaignButton>.Instance.RemoveLabel();
        CustomButtonSingleton<PlumberFlushButton>.Instance.RemoveLabel();
        CustomButtonSingleton<PlumberBlockButton>.Instance.RemoveLabel();
        CustomButtonSingleton<TransporterTransportButton>.Instance.RemoveLabel();

        CustomButtonSingleton<GlitchKillButton>.Instance.RemoveLabel();
        CustomButtonSingleton<InquisitorVanquishButton>.Instance.RemoveLabel();
        CustomButtonSingleton<JuggernautKillButton>.Instance.RemoveLabel();
        CustomButtonSingleton<PestilenceKillButton>.Instance.RemoveLabel();
        CustomButtonSingleton<WerewolfKillButton>.Instance.RemoveLabel();
        CustomButtonSingleton<AmnesiacRememberButton>.Instance.RemoveLabel();
        CustomButtonSingleton<GuardianAngelProtectButton>.Instance.RemoveLabel();
        CustomButtonSingleton<MercenaryGuardButton>.Instance.RemoveLabel();
        CustomButtonSingleton<MercenaryBribeButton>.Instance.RemoveLabel();
        CustomButtonSingleton<SurvivorVestButton>.Instance.RemoveLabel();
        CustomButtonSingleton<DoomsayerObserveButton>.Instance.RemoveLabel();
        CustomButtonSingleton<ArsonistDouseButton>.Instance.RemoveLabel();
        CustomButtonSingleton<ArsonistIgniteButton>.Instance.RemoveLabel();
        CustomButtonSingleton<GlitchHackButton>.Instance.RemoveLabel();
        CustomButtonSingleton<GlitchMimicButton>.Instance.RemoveLabel();
        CustomButtonSingleton<PlaguebearerInfectButton>.Instance.RemoveLabel();
        CustomButtonSingleton<SoulCollectorReapButton>.Instance.RemoveLabel();
        CustomButtonSingleton<VampireBiteButton>.Instance.RemoveLabel();
        CustomButtonSingleton<WerewolfRampageButton>.Instance.RemoveLabel();

        CustomButtonSingleton<EscapistMarkButton>.Instance.RemoveLabel();
        CustomButtonSingleton<EscapistRecallButton>.Instance.RemoveLabel();
        CustomButtonSingleton<GrenadierFlashButton>.Instance.RemoveLabel();
        CustomButtonSingleton<EclipsalBlindButton>.Instance.RemoveLabel();
        CustomButtonSingleton<MorphlingSampleButton>.Instance.RemoveLabel();
        CustomButtonSingleton<MorphlingMorphButton>.Instance.RemoveLabel();
        CustomButtonSingleton<SwooperSwoopButton>.Instance.RemoveLabel();
        CustomButtonSingleton<VenererAbilityButton>.Instance.RemoveLabel();
        CustomButtonSingleton<BomberPlantButton>.Instance.RemoveLabel();
        CustomButtonSingleton<BlackmailerBlackmailButton>.Instance.RemoveLabel();
        CustomButtonSingleton<HypnotistHypnotizeButton>.Instance.RemoveLabel();
        CustomButtonSingleton<JanitorCleanButton>.Instance.RemoveLabel();
        CustomButtonSingleton<MinerPlaceVentButton>.Instance.RemoveLabel();
        CustomButtonSingleton<UndertakerDragDropButton>.Instance.RemoveLabel();
        CustomButtonSingleton<WarlockKillButton>.Instance.RemoveLabel();
    }
    public static void RemoveLabel(this ActionButton? button)
    {
        button!.buttonLabelText.gameObject.SetActive(false);
    }
    public static void RemoveLabel(this CustomActionButton miraButton)
    {
        var button = miraButton.Button!;
        button.buttonLabelText.gameObject.SetActive(false);
        button.usesRemainingText.font = button.cooldownTimerText.font;
        button.usesRemainingText.fontMaterial = button.cooldownTimerText.fontMaterial;
    }
}