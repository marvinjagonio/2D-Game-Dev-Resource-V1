using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MeleeCombat : MonoBehaviour
{
    Rigidbody2D playerRb;
    Animator playerAnim;
    SpriteRenderer playerFlip;


    private bool isGrounded;
    private bool isJumping;
    public Transform groundCheck;
    public LayerMask groundIdentity;


    // Start is called before the first frame update
    void Start()
    {
      playerRb = GetComponent<Rigidbody2D>();  
      playerAnim = GetComponent<Animator>();
      playerFlip = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMovement(InputValue inputValue)
    {
        playerRb.velocity = inputValue.Get<Vector2>() * 5;
        PlayerAnimTracker();
    }

    private void OnAttack()
    {
        playerAnim.SetTrigger("isAttacking");
    }

    private void OnJump()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, .2f, groundIdentity);

        if(isGrounded)
        {
            playerRb.AddForce(Vector2.up * 7, ForceMode2D.Impulse);
            playerAnim.SetTrigger("isJumping");
        }

        
        
    }    


    void PlayerAnimTracker()
    {
        if (playerRb.velocity.x < 0)
        {
            playerAnim.SetBool("isRunning", true);
            playerFlip.flipX = true;
        }

        else if (playerRb.velocity.x > 0)
        {
            playerAnim.SetBool("isRunning", true);
            playerFlip.flipX = false;
        }

        else
        {
            playerAnim.SetBool("isRunning", false);
        }
    }

    
}
