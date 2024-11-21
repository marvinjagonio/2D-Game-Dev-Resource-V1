using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MeleeCombat : MonoBehaviour
{
    Rigidbody2D playerRb;
    Animator playerAnim;
    SpriteRenderer playerFlip;


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
        playerAnim.SetTrigger("PlayerAttack");
    }

    private void OnJump()
    {
        playerRb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
    }    


    void PlayerAnimTracker()
    {
        if (playerRb.velocity.x < 0)
        {
            playerAnim.SetTrigger("PlayerRun");
            playerFlip.flipX = true;
        }

        else if (playerRb.velocity.x > 0)
        {
            playerAnim.SetTrigger("PlayerRun");
            playerFlip.flipX = false;
        }

        else
        {
            playerAnim.SetTrigger("PlayerIdle");
        }
    }
}
