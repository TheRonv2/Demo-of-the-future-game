using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    private float moveInput;
    public float normalSpeed;
    private Rigidbody2D rb;
    public bool facingRight = true;
    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    private Animator anim;
    public VectorValue pos;
    public Teleport kk;
    public float gravityScale;

    private void Start()
    {
        transform.position = pos.initialValue;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
        if (moveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }
    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if (isGrounded == true)
        {
            anim.SetBool("isJumping", false);
        }
        else
        {
            anim.SetBool("isJumping", true);
        }

        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space) && (kk.open == false))
        {
            rb.velocity = Vector3.up * jumpForce;
            anim.SetTrigger("takeOf");
        }
        else if (isGrounded == true && Input.GetKeyDown(KeyCode.Space) && (kk.open == true))
        {
            rb.velocity = Vector3.down * jumpForce;
            anim.SetTrigger("takeOf");
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
