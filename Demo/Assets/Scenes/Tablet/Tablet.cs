using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablet : MonoBehaviour
{
    public Animator anim;
    public PcP pc;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if ((Input.GetKey(KeyCode.Q)) && (pc.tab == true))
        {
            anim.SetTrigger("eat 0");
            pc.tab1 = true;
            Destroy(this);
        }
    }
}