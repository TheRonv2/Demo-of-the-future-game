﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{

    public float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0.2f;
                Time.fixedDeltaTime = Time.timeScale = 0.02f;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }
}
