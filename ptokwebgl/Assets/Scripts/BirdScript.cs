using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public AudioClip jumpSound;
    public AudioSource audioSource;
    private Animator animator;
    private const string toggleKey = "SFXButtonToggled";

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) == true && birdIsAlive == true) 
        {
            jump();
        }
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            jump();
        }
    }

    public void jump()
    {
        myRigidbody.velocity = Vector2.up * flapStrength;
        int musicon = PlayerPrefs.GetInt(toggleKey, 0);

        if (musicon == 0)
        {
            audioSource.PlayOneShot(jumpSound);
        }
    }

    public void StopAnimation()
    {
        if (animator != null)
        {
            animator.enabled = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
        StopAnimation();
    }
}
