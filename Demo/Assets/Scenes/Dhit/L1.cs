using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1 : MonoBehaviour
{
    GameObject player;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        anim.Play("no");
    }

    // Update is called once per frame
    void Update()
    {
        float direction = player.transform.position.y - transform.position.y;
        float direction1 = player.transform.position.x - transform.position.x;
        if ((Mathf.Abs(direction) < 1) && (Mathf.Abs(direction1) < 5))
        {
            anim.Play("yes");
        }
        else if ((Mathf.Abs(direction) >= 1) && (Mathf.Abs(direction1) >= 5))
        {
            anim.Play("maybe");
        }
    }
}
