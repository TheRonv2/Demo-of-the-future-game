using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHand : MonoBehaviour
{

    public bool oh;

    // Start is called before the first frame update
    void Start()
    {
        oh = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            oh = true;
        }
    }
}
