using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blacknn : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Controll()
    {
        anim.Play("Black");
    }
}
