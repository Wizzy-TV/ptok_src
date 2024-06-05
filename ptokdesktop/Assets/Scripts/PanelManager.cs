using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject Panel;

    public void Settings()
    {
        Panel.GetComponent<Animator>().SetTrigger("Pop");
    }
}
