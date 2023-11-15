using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCam52 : MonoBehaviour
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

        if (Mathf.Abs(direction) < 18)
        {
            anim.Play("Camera52");
            Destroy(this);
        }

    }
}
