using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabletics : MonoBehaviour
{
    public PcP pc;
    public Animator anim;
    public Rigidbody2D rigidbody2D;
    public bool eatten = false;
    public bool uppen = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Stop"))
        {
            anim.SetBool("sit", true);
            rigidbody2D.constraints = RigidbodyConstraints2D.FreezePosition;
            pc.gg = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.Q)) && (eatten == false) && (uppen == false))
        {
            anim.SetBool("sit", false);
            anim.SetBool("eat", true);
            eatten = true;
        }

        if ((Input.GetKey(KeyCode.E)) && (eatten == true) && (uppen == false))
        {
            anim.SetBool("eat", false);
            anim.SetBool("up", true);
            uppen = true;
        }
    }

    void Come()
    {
        anim.SetBool("up", false);
        rigidbody2D.constraints = RigidbodyConstraints2D.None;
        rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
        pc.gg = false;
        Destroy(this);
    }
}
