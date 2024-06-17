using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordMenuScript : MonoBehaviour
{
    public GameObject record;
    public GameObject timeObject;

    public void showRecord()
    {
        if (!timeObject.activeSelf)
        {
            record.SetActive(true);
        }
    }

    public void hideRecord() 
    { 
        record.SetActive(false);
    }
}
