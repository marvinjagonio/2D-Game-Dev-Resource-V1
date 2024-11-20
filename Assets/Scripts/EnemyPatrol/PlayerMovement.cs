using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRb;

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        PlayerMovementControls();
        PlayerMovementTracker();
    }

    void PlayerMovementControls()
    {
        if (Input.GetKey(KeyCode.A))
        {
            playerRb.velocity = new Vector2(-3, playerRb.velocity.y);
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerRb.velocity = new Vector2(3, playerRb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            playerRb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
        }
    }

    void PlayerMovementTracker()
    {
        if(playerRb.velocity.x < 0)
        {
            Debug.Log("Player is moving left");
        }

        else if (playerRb.velocity.x > 0)
        {
            Debug.Log("Player is moving right");
        }
    }    
}
