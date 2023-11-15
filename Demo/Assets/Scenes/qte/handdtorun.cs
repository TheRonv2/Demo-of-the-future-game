using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handdtorun : MonoBehaviour
{
    public ObjectHand objectHand;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (objectHand.oh == true)
        {
            anim.SetTrigger("Handd");
        }
    }
}
