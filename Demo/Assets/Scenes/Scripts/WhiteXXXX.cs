using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteXXXX : MonoBehaviour
{
    public Light myLight;
    public float intens;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        intens = myLight.intensity;
    }
}
