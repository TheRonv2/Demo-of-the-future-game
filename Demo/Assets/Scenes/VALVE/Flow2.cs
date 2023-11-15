using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flow2 : MonoBehaviour
{

    private Animator anim;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float direction = player.transform.position.x - transform.position.x;
        if ((Input.GetKey(KeyCode.X)) && (Mathf.Abs(direction) < 1))
        {
            anim.Play("Flow2");
        }
        else if ((Input.GetKey(KeyCode.Z)) && (Mathf.Abs(direction) < 1))
        {
            anim.Play("RFlow2");
        }
        else
        {
            anim.Play("Stay2");
        }
    }
}
