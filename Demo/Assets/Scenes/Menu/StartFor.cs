using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFor : MonoBehaviour
{
    public static bool GameOnStart = true;
    public GameObject StartMenuUI;
    public bool gg = true;


    public void Resume()
    {
        GameOnStart = false;
        gg = false;
    }
}