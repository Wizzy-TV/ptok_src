using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroWaitScript : MonoBehaviour
{
    public float waitTime = 9f;

    void Start()
    {
        StartCoroutine(waitForIntro());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            skip();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            skip();
        }
    }

    IEnumerator waitForIntro()
    {
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void skip()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
