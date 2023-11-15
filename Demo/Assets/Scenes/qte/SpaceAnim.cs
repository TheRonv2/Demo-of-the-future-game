using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceAnim : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("SpaceButton", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bad"))
        {
            animator.SetBool("SpaceButton", true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Bad"))
        {
            animator.SetBool("SpaceButton", false);
        }
    }
}
