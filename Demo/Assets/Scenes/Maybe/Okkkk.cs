using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Okkkk : MonoBehaviour
{
    GameObject ground;
    GameObject ground1;
    GameObject ground2;
    public ups lol;
    public ups1 lol1;
    public ups2 lol2;
    public Animator anim;

    void Start()
    {
        ground = GameObject.FindWithTag("Ground");
        ground1 = GameObject.FindWithTag("Ground1");
        ground2 = GameObject.FindWithTag("Ground2");
    }

    void Update()
    {
        float direction = ground.transform.position.y- transform.position.y;
        float direction1 = ground1.transform.position.y - transform.position.y;
        float direction2 = ground2.transform.position.y - transform.position.y;

        if ((Mathf.Abs(direction) < 12) && (Mathf.Abs(direction) > 11) && (Mathf.Abs(direction1) < 9) && (Mathf.Abs(direction1) > 8) && (Mathf.Abs(direction2) < 5) && (Mathf.Abs(direction2) > 4))
        {
            Destroy(lol);
            Destroy(lol1);
            Destroy(lol2);
            anim.Play("fuck");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}