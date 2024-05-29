using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip[] songs;
    [SerializeField] private float trackTimer;
    private static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (!audioSource.isPlaying)
            ChangeSong(Random.Range(0, songs.Length));
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
