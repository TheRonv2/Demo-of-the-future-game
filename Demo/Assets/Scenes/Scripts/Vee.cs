using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vee : MonoBehaviour
{

    public Animator anim;
    GameObject player;
    public LilLight lil;
    public PlayerController controller;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float direction = player.transform.position.x - transform.position.x;
        if ((Mathf.Abs(direction) < 5) && (lil.open == true) && (controller.facingRight == true))
        {
            anim.Play("Vee");
            StartCoroutine("Timer");
        }
        else
        {
            anim.Play("NoVee");
            StopCoroutine("Timer");
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(6);
        Destroy(gameObject);
    }
}
