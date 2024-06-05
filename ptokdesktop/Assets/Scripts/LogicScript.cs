using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public Text highScoreText;
    private int highScore;
    public AudioSource audioSource;
    private const string toggleKey = "SFXButtonToggled";

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "RECORD: " + highScore.ToString();
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        int musicon = PlayerPrefs.GetInt(toggleKey, 0);
        if (musicon == 0)
        {
            audioSource.volume = 1;
            audioSource.Play();
        }
        gameOverScreen.SetActive(true);
        checkHighScore();
    }

    private void checkHighScore()
    {
        // Sprawd�, czy obecny wynik jest wi�kszy ni� rekordowy
        if (playerScore > highScore)
        {
            highScore = playerScore;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
            highScoreText.text = "RECORD: " + highScore.ToString();
        }
    }
}