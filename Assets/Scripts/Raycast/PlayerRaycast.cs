using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    Rigidbody2D PlayerRb;

    public float rayDistance = 1f;
    public LayerMask layerMask;
    private Vector2 playerDirection;

    private void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MovementControls();
        PlayerRaycastDetection();
    }

    private void MovementControls()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Time.deltaTime * 5);
            playerDirection = Vector2.left;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Time.deltaTime * 5);
            playerDirection = Vector2.right;
        }
    }

   private void PlayerRaycastDetection()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, playerDirection, rayDistance, layerMask);

        Debug.DrawRay(transform.position, playerDirection * rayDistance, Color.red);

        if (hit)
        {
            Debug.Log("Hit!");

            //Check if the object is close to target
            if(hit.distance < 1.5f)
            {
                Debug.Log("Close to target");
            }

        }

    }
}
