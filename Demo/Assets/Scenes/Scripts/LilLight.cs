using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LilLight : MonoBehaviour
{

    public Animator anim;
    public bool open = true;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.F)) && (open == false))
        {
            anim.Play("LL");
            open = !open;
        }
        else if ((Input.GetKeyDown(KeyCode.F)) && (open == true))
        {
            anim.Play("NoLL");
            open = !open;
        }
    }
}
