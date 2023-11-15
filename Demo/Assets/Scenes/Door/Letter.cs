using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour
{

    public Animator anim;
    public Animator anim1;
    GameObject player;
    public bool open = false;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        anim.Play("NoLetter");
        anim1.Play("NoPhone");
    }

    // Start is called before the first frame update
    private void Update()
    {

        float direction = player.transform.position.x - transform.position.x;
        if ((Input.GetKeyDown(KeyCode.Q)) && (open == false) && (Mathf.Abs(direction) < 2))
        {
            anim.Play("Letter");
            anim1.Play("Phone");
            open = !open;
        }
        else if (Mathf.Abs(direction) >= 2)
        {
            anim.Play("NoLetter");
            anim1.Play("NoPhone");
            open = false;
        }
        else if ((Input.GetKeyDown(KeyCode.Q)) && (open == true) && (Mathf.Abs(direction) < 2))
        {
            anim.Play("OutLetter");
            anim1.Play("OutPhone");
            open = !open;
        }
    }
}
