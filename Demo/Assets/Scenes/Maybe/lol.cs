using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lol : MonoBehaviour
{

    public Animator anim;
    public GameObject frame;
    public GameObject[] otherFrames;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Box"))
        {
            anim.SetTrigger("isTriggered");
            Cursor.visible = true;
            frame.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Destroy(this);
            foreach (GameObject frame in otherFrames)
            {
                frame.SetActive(false);
            }
        }
    }
}