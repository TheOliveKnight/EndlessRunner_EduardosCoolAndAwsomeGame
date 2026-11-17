using UnityEngine;

[CreateAssetMenu(fileName = "DefaultMenuConfig", menuName = "Geometry Slide/Menu Configuration")]
public class MenuConfigSO : ScriptableObject
{
    [Header("Text Defaults")]
    public string gameTitle = "Geometry Slide";
    public string startButtonText = "Start";
    public string coinLabelPrefix = "Coins Collected: ";
    public string settingsHeaderText = "Settings";
    public int defaultStartingCoins = 0;

    [Header("Background")]
    public Sprite menuBackgroundSprite;
    public Color fallbackBackgroundColor = new Color(0.137f, 0.137f, 0.137f, 1f);

    [Header("Theme Palette")]
    public Color primaryYellow = new Color(1f, 0.902f, 0.157f, 1f);      // #FFE628
    public Color bevelHighlightYellow = new Color(1f, 0.953f, 0.502f, 1f); // #FFF380
    public Color bevelShadowOrange = new Color(0.961f, 0.651f, 0.137f, 1f); // #F5A623
    public Color settingsButtonGreen = new Color(0.098f, 0.659f, 0.196f, 1f); // #19A832
    public Color cornerTileCyan = new Color(0.220f, 0.949f, 1f, 1f);     // #38F2FF

    [Header("Initial UI State")]
    public bool startWithSettingsOpen = false;
}