using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;
    public float runSpeed = 10;
    public float jumpForce = 300;
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public GroundChecker GroundChecker;
    public PlayerHealth healthPlayer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        healthPlayer = GetComponent<PlayerHealth>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        //health
        if (healthPlayer.isDead) return;

        float moveInput = Input.GetAxis("Horizontal");
        if (moveInput >= 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (moveInput < 0)
        {
            spriteRenderer.flipX = true;
        }
        //Sprint
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.velocity = new Vector2(moveInput * runSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        }
        //Jump
        if (Input.GetKeyDown(KeyCode.Space) && GroundChecker.isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }
}
