using UnityEngine;

[CreateAssetMenu(fileName = "GameSettings", menuName = "GeometrySlide/Game Settings", order = 1)]
public class GameSettingsSO : ScriptableObject
{
    [Header("Audio Settings")]
    [Range(0f, 1f)] public float masterVolume = 1.0f;
    [Range(0f, 1f)] public float sfxVolume = 1.0f;
    [Range(0f, 1f)] public float musicVolume = 1.0f;

    [Header("Gameplay Preferences")]
    public bool useTouchControls = false;
    public string playerName = "Player";
}