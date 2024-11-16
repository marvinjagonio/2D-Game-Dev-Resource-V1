using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    private Rigidbody2D playerRb;


    private bool canDoubleJump;
    private bool isGrounded;
    private bool isJumping;
    public Transform groundCheck;
    public LayerMask groundIdentity;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        
    }

    private void FixedUpdate()
    {
        
    }

    private void Update()
    {
        //PlayerJumpV1();
        PlayerJumpV2();
    }

    private void PlayerJumpV1()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, .2f, groundIdentity);

        if (isGrounded)
        {
            canDoubleJump = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                playerRb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
            }

            else
            {
                if (canDoubleJump)
                {
                    playerRb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
                    canDoubleJump = false;
                }
            }
        }

    }

    private void PlayerJumpV2()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, .2f, groundIdentity);

        // Reset jump-related flags only if the player is grounded and not actively jumping
        if (isGrounded && !isJumping)
        {
            canDoubleJump = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                playerRb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
                isJumping = true; // Player is now jumping
            }
            else if (canDoubleJump)
            {
                playerRb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
                canDoubleJump = false; // Disable double jump
            }
        }

        // Reset the jumping state when the player lands
        if (isGrounded)
        {
            isJumping = false;
        }
    }
}
