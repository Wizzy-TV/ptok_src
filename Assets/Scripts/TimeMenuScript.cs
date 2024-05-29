using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeMenuScript : MonoBehaviour
{
    private TimeSpan totalTimePlayed;
    public Text timeText;
    public GameObject timeObject;

    void Start()
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
    }

    private void OnGUI()
    {
        int hours = (int)totalTimePlayed.TotalHours;
        int minutes = totalTimePlayed.Minutes;

        timeText.text = $"Total Time Played: {hours} hours, {minutes} minutes";
    }

    public void showTime()
    {
        timeObject.SetActive(true);
    }

    public void hideTime()
    {
        timeObject.SetActive(false);
    }
}
