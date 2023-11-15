using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    GameObject player;
    public Rigidbody2D m_Rigidbody;
    public Teleport kk;
    public bool down = false;

    void Start()
    {
         player= GameObject.FindWithTag("Player");
         m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    //Метод который будет выполнятся по нажатию нашей кнопки.
    public void Update()
    {
        float direction = player.transform.position.x - transform.position.x;
        float direction1 = player.transform.position.y - transform.position.y;
        if ((Input.GetKeyDown(KeyCode.Q)) && (Mathf.Abs(direction) < 5) && (Mathf.Abs(direction1) < 5) && (kk.open == true) && (down == false))
        {
            m_Rigidbody.gravityScale = -1;
            down = !down;
        }
        else if ((kk.open == false) && (down == true))
        {
            m_Rigidbody.gravityScale = 1;
        }
        else if ((kk.open == true) && (down == true))
        {
            m_Rigidbody.gravityScale = -1;
        }
    }
}
