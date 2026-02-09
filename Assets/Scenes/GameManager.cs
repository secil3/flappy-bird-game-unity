using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject difficultyPanel;
    public GameObject startButton;
    public GameObject gameOverText;
    public GameObject titleText;
    public BirdController bird;
    private bool started = false;

    private bool isGameOver = false;
public enum Difficulty { Easy, Medium, Hard }
public Difficulty difficulty = Difficulty.Medium;

public void SetEasy()  { difficulty = Difficulty.Easy; }
public void SetMedium(){ difficulty = Difficulty.Medium; }
public void SetHard()  { difficulty = Difficulty.Hard; }
public GameObject easyButton;
public GameObject mediumButton;
public GameObject hardButton;


public float GetPipeSpeed()
{
    return difficulty == Difficulty.Easy ? 2.0f :
           difficulty == Difficulty.Medium ? 2.8f : 3.6f;
}

public float GetSpawnInterval()
{
    return difficulty == Difficulty.Easy ? 2.2f :
           difficulty == Difficulty.Medium ? 1.7f : 1.3f;
}


    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Time.timeScale = 0f;
        isGameOver = false;
        if (gameOverText) gameOverText.SetActive(false);
        if (difficultyPanel) difficultyPanel.SetActive(true);


        if (easyButton) easyButton.SetActive(true);
        if (mediumButton) mediumButton.SetActive(true);
        if (hardButton) hardButton.SetActive(true);


    }
    void Update()
{
    if (!started && Input.GetKeyDown(KeyCode.Return))
    {
        StartGame();
        return;
    }

    if (isGameOver && Input.GetKeyDown(KeyCode.Return))
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

  public void StartGame()
{
    if (difficultyPanel) difficultyPanel.SetActive(false);

    Time.timeScale = 1f;
    started = true;
    if (startButton) startButton.SetActive(false);
    if (titleText) titleText.SetActive(false);
    if (gameOverText) gameOverText.SetActive(false);
        
    if (easyButton) easyButton.SetActive(false);
    if (mediumButton) mediumButton.SetActive(false);
    if (hardButton) hardButton.SetActive(false);


    bird.SetStarted(true);
}

    public void GameOver()
    {
        if (isGameOver) return;
        isGameOver = true;
        Time.timeScale = 0f;
        if (gameOverText) gameOverText.SetActive(true);
    }
}
