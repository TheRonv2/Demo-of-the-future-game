using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Enemy : MonoBehaviour
{
    GameObject player;
    public LilLight lil;
    public Animator anim;
    public float speedMove = 30.0f;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        float direction = player.transform.position.x - transform.position.x;

        if ((Mathf.Abs(direction) < 15) && (lil.open == true))
        {
            Vector3 pos = transform.position;
            pos.x += Mathf.Sign(direction) * speedMove * Time.deltaTime;
            transform.position = pos;
            anim.Play("Monster1");
        }
        else if ((Mathf.Abs(direction) >= 15) && (lil.open == true))
        {
            anim.Play("Monster2");
        }
    }
}
