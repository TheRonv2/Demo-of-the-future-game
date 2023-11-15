using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Format : MonoBehaviour
{
    public Camera m_OrthographicCamera;
    public float Size;

    void Start()
    {
        m_OrthographicCamera.orthographicSize = 10.0f;

    }

    void Update()
    {
        if ((Input.GetKey(KeyCode.D)) && (m_OrthographicCamera.orthographicSize == Size) && (m_OrthographicCamera.orthographicSize > 4))
        {
            m_OrthographicCamera.orthographicSize -= 0.001f;
            Size -= 0.001f;
        }
        else if ((Input.GetKey(KeyCode.D)) && (Size > 4))
        {
            Size -= 0.001f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Size += 0.001f;
        }
    }
}