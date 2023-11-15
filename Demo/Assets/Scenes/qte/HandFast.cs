using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandFast : MonoBehaviour
{
    public RunGamer gamer;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gamer.speed = 6;
        }
    }
}

