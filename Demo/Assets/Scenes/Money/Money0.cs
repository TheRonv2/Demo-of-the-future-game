using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money0 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.CompareTag("Player")) && (MoneyText.Coin > 1))
        {
            MoneyText.Coin = 0;
            PlayerPrefs.SetInt("coins", MoneyText.Coin);
            Destroy(gameObject);
        }
    }
}
