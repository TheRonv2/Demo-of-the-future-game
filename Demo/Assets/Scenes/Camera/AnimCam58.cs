using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCam58 : MonoBehaviour
{
    public Animator anim;
    GameObject Camera;

    void Start()
    {
        Camera = GameObject.FindWithTag("MainCamera");
    }

    void Update()
    {
        float direction = Camera.transform.position.x - transform.position.x;

        if (Mathf.Abs(direction) < 12)
        {
            anim.Play("Camera58");
            Destroy(this);
        }

    }
}
