using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour
{
    public TextMeshProUGUI label;
    public Image icon;
    public Sprite iconOn;
    public Sprite iconOff;

    void Start()
    {
        bool muted = PlayerPrefs.GetInt("Muted", 0) == 1;
        SetMuted(muted);
    }

    public void Toggle()
    {
        bool muted = PlayerPrefs.GetInt("Muted", 0) == 1;
        SetMuted(!muted);
    }

    void SetMuted(bool muted)
    {
        AudioListener.pause = muted;
        PlayerPrefs.SetInt("Muted", muted ? 1 : 0);
        if (icon) icon.sprite = muted ? iconOff : iconOn;
    }
}
