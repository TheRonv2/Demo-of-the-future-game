using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ups : MonoBehaviour
{

    //Наш объект.
    public GameObject box;
    GameObject player;
    public Animator anim;

    //Целочисленная переменная определяющая дистанцию перемещения.
    public float S;
    public float K;

    void Start()
    {
        S = 0f;
        K = 0f;
        player = GameObject.FindWithTag("Player");
    }

    //Метод который будет выполнятся по нажатию нашей кнопки.
    public void Update()
    {
        S = 0.004f;
        K = 0.004f;
        if ((MoneyText.Coin == 5) || (MoneyText.Coin == 45) || (MoneyText.Coin == 85) || (MoneyText.Coin == 125))
        {
            anim.Play("Wake");
            float direction = player.transform.position.x - transform.position.x;
            if ((Input.GetKey(KeyCode.M)) && (Mathf.Abs(direction) < 1))
            {
                box.transform.Translate(0, S, 0);
            }

            if ((Input.GetKey(KeyCode.N)) && (Mathf.Abs(direction) < 1))
            {
                box.transform.Translate(0, 0 - K, 0);
            }
        }
        
    }
}