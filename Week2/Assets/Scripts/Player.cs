using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;
    private AudioSource audiosource;

    private void Start()
    {
        animator = GetComponent<Animator>();
        audiosource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKey("a"))
        {
            animator.SetInteger("walk", 1);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKey("d"))
        {
            animator.SetInteger("walk", 2);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey("w"))
        {
            animator.SetInteger("walk", 3);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            animator.SetInteger("walk", 0);
        }
    }

    // coin audio:
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Coin")
        {
            audiosource.Play();
        }
    }


}
