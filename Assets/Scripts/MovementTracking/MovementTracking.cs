using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTracking : MonoBehaviour
{
    private float previousPlayerPosition;
   
    private void Start()
    {
        //Store the initial position of the object
        previousPlayerPosition = transform.position.x;
    }
    private void Update()
    {
        PlayerControls();

        //Get the current position
        float currentPlayerPosition = transform.position.x;

        if(currentPlayerPosition < previousPlayerPosition)
        {
            Debug.Log("Player is moving left");
        } 
        
        else if(currentPlayerPosition > previousPlayerPosition)
        {
            Debug.Log("Player is moving right");

        }

        else 
        {
            Debug.Log("Player is not moving");
        }

        //Update the previous position for the next frame
        previousPlayerPosition = currentPlayerPosition;


        
    }

    void PlayerControls()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * 3 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * 3 * Time.deltaTime);
        }
    }


    /* ADDED MOVEMENT TRACKER */

}
