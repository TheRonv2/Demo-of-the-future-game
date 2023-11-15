using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectSkin : MonoBehaviour
{
    public GameObject Skin1, Skin2;
    int selectSkin1, selectSkin2;
    public static int SelectScin2;
    Text text;
    int BuySkin;
    void Start()
    {
        selectSkin1 = PlayerPrefs.GetInt("selectSkin1", 1);
        selectSkin2 = PlayerPrefs.GetInt("selectSkin2", 1);
        text = GetComponent<Text>();
        selectSkin2 = PlayerPrefs.GetInt("selectskin", selectSkin2);
        BuySkin = PlayerPrefs.GetInt("BuySkin", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (selectSkin1 == 1)
        {
            Skin1.SetActive(true);
            Skin2.SetActive(false);
        }
        else
        {
            Skin1.SetActive(false);
        }

        if (selectSkin2 == 2)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(true);
        }
        else
        {
            Skin2.SetActive(false);
        }

        if (BuySkin == 2)
        {
            text.text = BuySkin.ToString();
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

    public void SelectOneSkin()
    {
        selectSkin1 = 1;
        PlayerPrefs.SetInt("selectSkin1", selectSkin1);
        selectSkin2 = 1;
        PlayerPrefs.SetInt("selectSkin2", selectSkin2);
    }

    public void SelectTwoSkin()
    {
        selectSkin1 = 2;
        PlayerPrefs.SetInt("selectSkin1", selectSkin1);
        selectSkin2 = 2;
        PlayerPrefs.SetInt("selectSkin2", selectSkin2);
    }
}