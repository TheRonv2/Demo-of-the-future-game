using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cion : MonoBehaviour
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
        if (collision.CompareTag("Player"))
        {
            MoneyText.Coin -= 10;
            PlayerPrefs.SetInt("coins", MoneyText.Coin);
            Destroy(gameObject);
        }
    }
}