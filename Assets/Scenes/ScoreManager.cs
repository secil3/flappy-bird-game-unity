using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public AudioSource scoreAudio;

    private int score = 0;
    private int highScore = 0;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        scoreText.text = "Score: 0";
        highScoreText.text = "High Score: " + highScore;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            highScoreText.text = "High Score: " + highScore;
        }

        if (scoreAudio) scoreAudio.Play();
    }
}
