using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour
{

    //Наш объект.
    public GameObject no;
    GameObject player;
    public Rigidbody2D rb;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
    }

    //Метод который будет выполнятся по нажатию нашей кнопки.
    public void Update()
    {
        float direction = player.transform.position.x - transform.position.x;
        if ((Input.GetKey(KeyCode.Q)) && (Mathf.Abs(direction) < 5))
        {
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        else if ((Input.GetKeyUp(KeyCode.Q)) || (Mathf.Abs(direction) >= 5))
        {
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
        }
    }
}