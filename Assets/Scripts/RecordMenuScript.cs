using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordMenuScript : MonoBehaviour
{
    public GameObject record;

    public void showRecord()
    {
        record.SetActive(true);
    }

    public void hideRecord() 
    { 
        record.SetActive(false);
    }
}
