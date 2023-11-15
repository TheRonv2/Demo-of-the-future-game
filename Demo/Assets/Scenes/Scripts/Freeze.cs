using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : MonoBehaviour
{
    public Rigidbody2D m_Rigidbody;
    GameObject bad;

    void Start()
    {
        bad = GameObject.FindWithTag("Bad");
        m_Rigidbody.constraints = RigidbodyConstraints2D.FreezePositionX;
    }

    void Update()
    {
        float direction = bad.transform.position.y - transform.position.y;
        if (Mathf.Abs(direction) < 20)
        {
            m_Rigidbody.constraints = RigidbodyConstraints2D.None;
            Destroy(this);
        }
    }

}
