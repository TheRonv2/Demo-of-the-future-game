using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCamera1 : MonoBehaviour
{
    public Animator anim;
    GameObject Camera;

    void Start()
    {
        Camera = GameObject.FindWithTag("MainCamera");
    }

    void Update()
    {
        float direction = Camera.transform.position.y - transform.position.y;

        if (Mathf.Abs(direction) < 280)
        {
            anim.Play("AnimCamera1");
            Destroy(this);
        }

    }
}
