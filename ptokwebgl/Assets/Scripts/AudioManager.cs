using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] songs;
    [SerializeField] private float trackTimer;
    public static AudioManager instance;
    private const string toggleKey = "MusicButtonToggled";

    void Start()
    {
        GameObject audioSourceObject = GameObject.FindGameObjectWithTag("Audio");

        if (audioSourceObject != null)
        {
            audioSource = audioSourceObject.GetComponent<AudioSource>();
        }
        if (!audioSource.isPlaying)
            ChangeSong(Random.Range(0, songs.Length));

        int musicon = PlayerPrefs.GetInt(toggleKey, 0);
        if (musicon == 0)
        {
            audioSource.volume = 1;
            audioSource.Play();
        }
        else
        {
            audioSource.volume = 0;
            audioSource.Play();
        }
    }

    void Update()
    {

        if (audioSource.isPlaying)
            trackTimer += 1 * Time.deltaTime;

        if (!audioSource.isPlaying || trackTimer >= audioSource.clip.length)
            ChangeSong(Random.Range(0, songs.Length));
    }

    public void ChangeSong(int songPicked)
    {
        trackTimer = 0;
        audioSource.clip = songs[songPicked];
        audioSource.Play();
    }
}
