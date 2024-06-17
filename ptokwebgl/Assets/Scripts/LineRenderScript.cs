using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRenderScript : MonoBehaviour
{
    public GameObject gameObject;
    public float score;

    void Start()
    {
        int score = PlayerPrefs.GetInt("HighScore", 0);

        float moveAmount = score * 13.5f;
        Vector3 moveDirection = new Vector3(moveAmount, 0f, 0f);

        gameObject.transform.Translate(moveDirection);
    }
}
