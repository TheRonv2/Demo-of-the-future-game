using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nopevvv : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float force;
    public float jumpForce;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2D.AddForce(Vector2.left * force * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigidbody2D.AddForce(Vector2.right * force * Time.fixedDeltaTime);
        }
    }
}