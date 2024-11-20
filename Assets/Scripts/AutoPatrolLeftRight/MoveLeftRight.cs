using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRight : MonoBehaviour
{
    public float distance = 5f;  // Total movement distance
    public float speed = 2f;     // Speed of movement

    private Vector2 startPosition;  // The initial position of the object

    void Start()
    {
        // Record the starting position
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new X position using a sine wave
        float offsetX = Mathf.Sin(Time.time * speed) * (distance / 2f);

        // Update the object's position
        transform.position = new Vector2(startPosition.x + offsetX, startPosition.y);
    }
}
