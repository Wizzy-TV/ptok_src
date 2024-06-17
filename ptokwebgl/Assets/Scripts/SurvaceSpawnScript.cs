using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvaceSpawnScript : MonoBehaviour
{
    public GameObject survace;
    public float spawnRate = 6;
    private float timer = 0;

    void Start()
    {
        spawnSurvace();
    }

    void Update()
    {
        if (timer < spawnRate) 
        { 
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnSurvace();
            timer = 0;
        }
    }
    void spawnSurvace()
    {
        Instantiate(survace, transform.position, transform.rotation);
    }
}
