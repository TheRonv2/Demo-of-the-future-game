using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim3 : MonoBehaviour
{
    public Animator light;

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        light.Play("Fire3");
    }
}