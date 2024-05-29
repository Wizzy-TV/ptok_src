using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvaceMoveScript : MonoBehaviour
{
    public float moveSpeed = 9;
    public float deadZone = -138;

    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
