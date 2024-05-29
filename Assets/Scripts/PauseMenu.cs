using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public void pauseGame()
    {
        Time.timeScale = 0.0f;
        pauseMenuUI.SetActive(true);
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
