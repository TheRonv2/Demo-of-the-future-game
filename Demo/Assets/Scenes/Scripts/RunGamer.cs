using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunGamer : MonoBehaviour
{
    public int speed;
    public bool ck;
    public float jumpForce;
    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    private Animator anim;
    private Rigidbody2D rb;
    GameObject bad;
    GameObject bocs;
    GameObject finish;
    GameObject stop;
    public VectorValue pos;
    public bool jp;
    public bool mp;
    public bool rn;
    public bool ts;
    public bool st;
    public bool fn;

    // Start is called before the first frame update
    void Start()
    {
        jp = false;
        ck = false;
        mp = false;
        rn = false;
        ts = false;
        st = false;
        fn = false;
        transform.position = pos.initialValue;
        bad = GameObject.FindWithTag("Bad");
        bocs = GameObject.FindWithTag("Bocs");
        stop = GameObject.FindWithTag("Stop");
        finish = GameObject.FindWithTag("Finish");
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        if ((ts == true) && Input.GetKeyDown(KeyCode.Space))
        {
            jp = true;
        }
        if ((isGrounded == true) && (jp == true) && (st == true))
        {
            rb.velocity = Vector3.up * jumpForce;
            anim.SetTrigger("takeOf");
        }

        if (isGrounded == true)
        {
            anim.SetBool("isJumping", false);
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isJumping", true);
        }

        if ((ck == true) && Input.GetKeyDown(KeyCode.D))
        {
            mp = true;
        }
        if ((mp == true) && (fn == true))
        {
            anim.SetTrigger("RunFasting1");
            speed = 16;
        }
        if (speed == 16)
        {
            rn = true;
        }
        else
        {
            rn = false;
        }

    }

    void Stop()
    {
        anim.SetTrigger("RunFasting");
        speed = 10;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Respawn"))
        {
            ck = true;
        }
        if (other.CompareTag("Bad"))
        {
            ts = true;
        }
        if (other.CompareTag("Stop"))
        {
            st = true;
        }
        if (other.CompareTag("Finish"))
        {
            fn = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Respawn"))
        {
            ck = false;
        }
        if (other.CompareTag("Bad"))
        {
            jp = false;
            ts = false;
            st = false;
        }
        if (other.CompareTag("Finish"))
        {
            mp = false;
        }
    }
}
