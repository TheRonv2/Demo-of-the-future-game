using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class up2 : MonoBehaviour
{

    //Наш объект.
    public GameObject box2;
    GameObject player;

    //Целочисленная переменная определяющая дистанцию перемещения.
    public float S;
    public float K;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    //Метод который будет выполнятся по нажатию нашей кнопки.
    public void Update()
    {
        float direction = player.transform.position.x - transform.position.x;
        if ((Input.GetKey(KeyCode.M)) && (Mathf.Abs(direction) < 1))
        {
            box2.transform.Translate(0, S, 0);
        }

        if ((Input.GetKey(KeyCode.N)) && (Mathf.Abs(direction) < 1))
        {
            box2.transform.Translate(0, 0 - K, 0);
        }
    }
}