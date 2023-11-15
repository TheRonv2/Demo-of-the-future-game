using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneScr : MonoBehaviour
{
    public bool GameIsPaused = false;
    public bool phon = false;
    public GameObject PauseMenuUI;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameIsPaused)
            {
                PhoneOn();
            }
            else
            {
                PhoneOff();
            }
        }
    }

    public void PhoneOn()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void PhoneOff()
    {
        if (phon == true)
        {
            PauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
    }
}
