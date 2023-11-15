using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCam34 : MonoBehaviour
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

        if (Mathf.Abs(direction) < 36)
        {
            anim.Play("Camera34");
            Destroy(this);
        }

    }
}