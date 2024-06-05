using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SFXButton : MonoBehaviour
{
    public Button myButton;
    public Sprite newImage;

    private Sprite oldImage;

    private bool isToggled = false;
    private const string toggleKey = "SFXButtonToggled";

    void Start()
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
        }
        else
        {
            myButton.image.sprite = oldImage;
        }
    }
}
