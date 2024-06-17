using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameTimeTracker : MonoBehaviour
{
    private DateTime startTime;
    private TimeSpan totalTimePlayed;
    private const float saveInterval = 60f;
    private static GameTimeTracker instance;

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

    private void Start()
    {
        if (PlayerPrefs.HasKey("TotalTimePlayed"))
        {
            long temp = Convert.ToInt64(PlayerPrefs.GetString("TotalTimePlayed"));
            totalTimePlayed = TimeSpan.FromTicks(temp);
        }
        else
        {
            totalTimePlayed = TimeSpan.Zero;
        }

        startTime = DateTime.Now;

        InvokeRepeating("SaveGameTime", saveInterval, saveInterval);
    }

    private void OnApplicationQuit()
    {
        SaveGameTime();
    }

    private void SaveGameTime()
    {
        TimeSpan sessionTime = DateTime.Now - startTime;

        totalTimePlayed += sessionTime;

        PlayerPrefs.SetString("TotalTimePlayed", totalTimePlayed.Ticks.ToString());
        PlayerPrefs.Save();

        startTime = DateTime.Now;
    }
}
