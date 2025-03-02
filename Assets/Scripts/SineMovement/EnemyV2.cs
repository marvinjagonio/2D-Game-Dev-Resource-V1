using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyV2 : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 3f;

    private Rigidbody2D rb;
    private Vector2 referencePosition;
    private float timeOffset;


    public Transform player;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        referencePosition = rb.position; //set the inital reference position
        timeOffset = Time.time;

    }

    private void FixedUpdate()
    {
        //PatrolMovement();
        FollowMovement();
    }

    private void PatrolMovement()
    {
        if (Vector2.Distance(rb.position, referencePosition) > distance)
        {
            referencePosition = rb.position;
            timeOffset = Time.time; //reset time offset to keep motion smooth
        }


        //calculate sine wave movement
        float offsetX = Mathf.Sin((Time.time - timeOffset) * speed) * (distance / 2f);
        float targetX = referencePosition.x + offsetX;

        //Calculate velocity required to move smoothly
        float velocityX = (targetX - rb.position.x) / Time.fixedDeltaTime;

        //Apply Velocity
        rb.velocity = new Vector2(velocityX, rb.velocity.y);
    }

    private void FollowMovement()
    {
        if (player == null) return;

        //calculate direction towards the player
        Vector2 direction = (player.position - (Vector3)rb.position).normalized;

        //apply velocity to move towards the player
        rb.velocity = direction * speed;
    }
}
