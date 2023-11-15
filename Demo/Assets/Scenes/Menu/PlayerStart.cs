using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStart : MonoBehaviour
{
    public SpriteRenderer m_SpriteRenderer;
    public Rigidbody2D rigidbody2D;
    public bool gg = true;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = new Color(1, 1, 1, 0);
    }

    void Update()
    {
        if (gg == true)
        {
            rigidbody2D.constraints = RigidbodyConstraints2D.FreezePosition;
        }
        else if (gg == false)
        {
            rigidbody2D.constraints = RigidbodyConstraints2D.None;
            rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
            m_SpriteRenderer.color = new Color(1, 1, 1, 1);
        }
    }
}
