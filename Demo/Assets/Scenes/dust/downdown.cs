using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downdown : MonoBehaviour
{
    public DownController dc;
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

    private void Start()
    {
        transform.position = pos.initialValue;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    private void FixedUpdate()
    {
        if (dc.dd == true)
        {
            Vector3 Scaler = transform.localScale;
            Scaler.x = 5;
            transform.localScale = Scaler;
            facingRight = true;
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
    }

    private void Update()
    {
        if (dc.dd == true)
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

            if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = Vector3.up * jumpForce;
                anim.SetTrigger("takeOf");
            }
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