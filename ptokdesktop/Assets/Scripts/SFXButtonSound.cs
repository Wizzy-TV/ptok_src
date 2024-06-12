using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXButton1 : MonoBehaviour
{
    public AudioSource audioSource;
    private const string toggleKey = "SFXButtonToggled";

    public void PlaySound()
    {
        int musicon = PlayerPrefs.GetInt(toggleKey, 0);

        if (musicon == 0)
        {
            audioSource.volume = 0.65f;
            audioSource.Play();
        }
    }
}
