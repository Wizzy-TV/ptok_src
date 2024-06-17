using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenFader : MonoBehaviour
{
    public float fadeDuration = 1.0f;

    public Image fadeImage;
    private float fadeStartTime;
    private bool isFading = false;

    void Start()
    {
        fadeImage = GetComponentInChildren<Image>();
        if (fadeImage != null)
        {
            fadeImage.raycastTarget = false;
            fadeImage.color = Color.black;
            fadeStartTime = Time.time;
            isFading = true;
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
            fadeImage.color = new Color(0, 0, 0, 1.0f - t);
        }
    }
}
