using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTextOnTheMap : MonoBehaviour
{
    public float moveSpeed = 9;

    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
