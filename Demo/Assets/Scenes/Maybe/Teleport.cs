using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    //Наш объект.

    //Целочисленная переменная определяющая дистанцию перемещения.
    public float S;
    public float K;
    public bool open = false;
    GameObject teleport;
    GameObject teleport1;

    void Start()
    {
        teleport = GameObject.FindWithTag("Teleport");
        teleport1 = GameObject.FindWithTag("Teleport1");
    }

    //Метод который будет выполнятся по нажатию нашей кнопки.
    public void Update()
    {
        float direction = teleport.transform.position.x - transform.position.x;
        float direction1 = teleport1.transform.position.x - transform.position.x;
        if ((Input.GetKeyDown(KeyCode.M)) && (open == true) && ((Mathf.Abs(direction) < 1) || (Mathf.Abs(direction1) < 1)))
        {
            this.transform.Rotate(K, 0, 0);
            this.transform.Translate(0, 0 - S, 0);
            Physics2D.gravity = new Vector2(0, -9.8f);
            open = !open;
        }
        else if ((Input.GetKeyDown(KeyCode.M)) && (open == false) && ((Mathf.Abs(direction) < 1) || (Mathf.Abs(direction1) < 1)))
        {
            this.transform.Rotate(K, 0, 0);
            this.transform.Translate(0, 0 - S, 0);
            Physics2D.gravity = new Vector2(0, 9.8f);
            open = !open;
        }
    }
}
