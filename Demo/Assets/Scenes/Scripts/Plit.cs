using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plit : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.CompareTag("Player")) || (other.CompareTag("Box")))
        {
            anim.Play("Down");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if ((other.CompareTag("Player")) || (other.CompareTag("Box")))
        {
            anim.Play("NoDown");
        }
    }

}
