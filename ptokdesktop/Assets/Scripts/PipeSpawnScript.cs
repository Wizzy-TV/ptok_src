using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 1.5f;
    private float nextSpawnTime = 0f;
    public float heightOffset = 10f;

    void Start()
    {
        nextSpawnTime = Time.time + spawnRate;
        SpawnPipe();
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnPipe();
            nextSpawnTime += spawnRate;
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Vector3 spawnPosition = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0);

        Instantiate(pipe, spawnPosition, transform.rotation);
    }
}
