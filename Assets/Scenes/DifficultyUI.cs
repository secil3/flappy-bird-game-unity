using UnityEngine;
using UnityEngine.UI;
public class DifficultyUI : MonoBehaviour
{

    public Button easy;
    public Button medium;
    public Button hard;

    public Color selected = new Color32(255, 224, 130, 255);
    public Color normal = new Color32(160, 179, 192, 255);

    public void SelectEasy()
    {
        SetColors(easy);
    }

    public void SelectMedium()
    {
        SetColors(medium);
    }

    public void SelectHard()
    {
        SetColors(hard);
    }

    void SetColors(Button selectedBtn)
    {
        easy.image.color = normal;
        medium.image.color = normal;
        hard.image.color = normal;
        selectedBtn.image.color = selected;
    }
}
