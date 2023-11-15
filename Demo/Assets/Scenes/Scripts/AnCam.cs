using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnCam : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Control()
    {
        anim.Play("Bniz");
    }
}
