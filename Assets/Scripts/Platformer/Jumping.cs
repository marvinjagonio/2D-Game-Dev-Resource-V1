using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    private Rigidbody2D playerRb;

    private bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundIdentity;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, .2f, groundIdentity);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                playerRb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
            }
        }
    }
}
