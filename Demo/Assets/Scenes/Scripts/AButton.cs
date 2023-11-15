using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AButton : MonoBehaviour
{
    public Animator anim;
    public GameObject frame;
    public GameObject[] otherFrames;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.CompareTag("Player")))
        {
            anim.SetTrigger("isTriggered");
            frame.SetActive(true);
            foreach (GameObject frame in otherFrames)
            {
                frame.SetActive(false);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if ((other.CompareTag("Player")))
        {
            anim.SetTrigger("isTriggered");
        }
    }
}