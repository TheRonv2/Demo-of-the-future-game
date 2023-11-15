using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject ShopMenu;

    public static bool GameIsPaused = false;

    void Start()
    {
        ShopMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void OpenShopMenu()
    {
        ShopMenu.SetActive(true);
    }

    public void CloseShopMenu()
    {
        ShopMenu.SetActive(false);
    }

    public void Resume()
    {
        ShopMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        ShopMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }

}
