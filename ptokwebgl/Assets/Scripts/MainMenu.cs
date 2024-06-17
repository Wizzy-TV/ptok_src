using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public float fadeDuration = 1.0f;

    public Image fadeImage;
    private float fadeStartTime;
    private bool isFading = false;

    void Start()
    {
       if (fadeImage != null)
       {
            fadeImage.color = new Color(0, 0, 0, 0);
       }
    }

    void Update()
    {
        if (isFading)
        {
            float t = (Time.time - fadeStartTime) / fadeDuration;

            if (t >= 1.0f)
            {
                t = 1.0f;
                isFading = false;
            }

            fadeImage.color = new Color(0, 0, 0, t);
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
