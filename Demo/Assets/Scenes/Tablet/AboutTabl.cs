using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutTabl : MonoBehaviour
{
    public PcP pc;
    public Animator anim;
    public Rigidbody2D rigidbody2D;
    GameObject stop;

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
            anim.SetTrigger("sit 0");
            rigidbody2D.constraints = RigidbodyConstraints2D.FreezePosition;
            pc.gg = true;
            pc.tab = true;
            Destroy(this);
        }
    }

}
