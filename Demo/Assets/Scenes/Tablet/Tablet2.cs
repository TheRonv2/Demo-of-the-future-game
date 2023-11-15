using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablet2 : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rigidbody2D;
    public PcP pc;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if ((Input.GetKey(KeyCode.E)) && (pc.tab == true) && (pc.tab1 == true))
        {
            anim.SetTrigger("up 0");
        }
    }

    void Come()
    {
        rigidbody2D.constraints = RigidbodyConstraints2D.None;
        rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
        pc.gg = false;
        Destroy(this);
    }
}