using UnityEngine;
using UnityEngine.UI;

public class ButtonImageToggle : MonoBehaviour
{
    public Button myButton;
    public Sprite newImage;
    public AudioSource audioSource;
    public float volume;

    private Sprite oldImage;

    private bool isToggled = false;
    private const string toggleKey = "MusicButtonToggled";

    private void Start()
    {
        oldImage = myButton.image.sprite;

        isToggled = PlayerPrefs.GetInt(toggleKey, 0) == 1;

        UpdateButtonImage();

        myButton.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        isToggled = !isToggled;

        PlayerPrefs.SetInt(toggleKey, isToggled ? 1 : 0);
        PlayerPrefs.Save();

        UpdateButtonImage();
    }

    private void UpdateButtonImage()
    {
        if (isToggled)
        {
            myButton.image.sprite = newImage;
            audioSource.volume = 0;
            audioSource.Play();
        }
        else
        {
            myButton.image.sprite = oldImage;
            audioSource.volume = 1;
            audioSource.Play();
        }
    }
}
