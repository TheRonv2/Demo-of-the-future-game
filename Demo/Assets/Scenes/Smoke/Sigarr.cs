using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sigarr : MonoBehaviour
{
    public PlayerCont cont;
    public SpriteRenderer m_SpriteRenderer;
    public Pause_menu pause;

    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = new Color(1, 1, 1, 0);
        pause.sf = false;
    }

    void Update()
    {
        if (cont.sig == true)
        {
            m_SpriteRenderer.color = new Color(1, 1, 1, 1);
            pause.sf = true;
        }
    }
}
