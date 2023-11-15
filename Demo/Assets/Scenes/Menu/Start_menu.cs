using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_menu : MonoBehaviour
{
    public PlayerCont pc;
    public StartFor kk;
    public Animator anim;
    public Rigidbody2D rigidbody2D;

    void Start()
    {
        anim = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.constraints = RigidbodyConstraints2D.FreezePosition;
    }

    void Update()
    {
        if (kk.gg == false)
        {
            anim.SetTrigger("smoke");
        }
    }

    void Fixe()
    {
        rigidbody2D.constraints = RigidbodyConstraints2D.None;
        rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
        pc.dd = false;
    }
}
