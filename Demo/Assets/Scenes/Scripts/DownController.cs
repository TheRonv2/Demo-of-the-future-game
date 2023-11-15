using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownController : MonoBehaviour
{
    public nopevv nv;
    public GameObject dust1;
    public bool dd = false;

    void Start()
    {
        nv = GetComponent<nopevv>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Stop"))
        {
            {
                Destroy(nv);
                dd = true;
                Destroy(this);
                Destroy(dust1);
            }
        }
    }
}
