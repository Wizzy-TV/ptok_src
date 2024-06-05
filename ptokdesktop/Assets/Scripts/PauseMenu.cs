using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject pauseMenuUI;
    private BirdScript birdScript;

    void Start()
    {
        birdScript = GameObject.FindObjectOfType<BirdScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            togglePause();
        }
    }

    public void togglePause()
    {
        isPaused = !isPaused;

        if (isPaused && birdScript.birdIsAlive)
        {
            pauseGame();
        }
        else
        {
            resumeGame();
        }

    }

    public void restartGame()
    {
        resumeGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void pauseGame()
    {
        Time.timeScale = 0.0f;
        pauseMenuUI.SetActive(true);
    }
    public void ReturnToMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void resumeGame()
    {
        Time.timeScale = 1.0f;
        pauseMenuUI.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
