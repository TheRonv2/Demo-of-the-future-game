using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fasttttttt : MonoBehaviour
{
    public Fastt fastt;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        if (fastt.dd == true)
        {
            Destroy(gameObject);
        }
    }
}
