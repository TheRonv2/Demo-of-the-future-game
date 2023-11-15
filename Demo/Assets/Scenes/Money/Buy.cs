using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;

public class Buy : MonoBehaviour
{
    public GameObject BuyButton;
    int BuySkin; 
    void Start()
    {
        BuySkin = PlayerPrefs.GetInt("BuySkin", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (BuySkin == 1)
        {
            BuyButton.SetActive(true);
        }
        else
        {
            BuyButton.SetActive(false);
        }
    }

    public void BuySkins()
    {
        if (MoneyText.Coin >= 5)
        {
            MoneyText.Coin -= 5;
            PlayerPrefs.SetInt("coins", MoneyText.Coin);
            BuySkin = 2;
            PlayerPrefs.GetInt("BuySkin", 2);
        } 
    }
}