using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRenderScript : MonoBehaviour
{
    public GameObject targetGameObject;
    public float score;

    void Start()
    {
        int score = PlayerPrefs.GetInt("HighScore", 0);

        if (score == 0)
        {
            targetGameObject.SetActive(false);
        }
        else
        {
            float moveAmount = score * 13.5f;
            Vector3 moveDirection = new Vector3(moveAmount, 0f, 0f);

            targetGameObject.transform.Translate(moveDirection);
        }
    }
}
