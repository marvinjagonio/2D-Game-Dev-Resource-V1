using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    private Vector2 _moving = Vector2.left;
    [SerializeField] float enemyPosLeft;
    [SerializeField] float enemyPosRight;
    [SerializeField] int enemyMoveSpeed;

    public float rayDistance = 1f;
    public LayerMask layerMask;
    private Vector2 playerDirection;

    public Transform player;

    private bool patrolNow = false;

    private void Start()
    {
        playerDirection = Vector2.left;

        StartCoroutine(EnemyPatrolTrigger());
    }

    private void Update()
    {
        EnemyMovementPatrolV1();
        EnemyMovementFollow();

        EnemyRaycastDetection();

        //EnemyMovementPatrolV2();

    }

    /* ENEMY PATROL USING NORMAL LEFT AND RIGHT COORDINATE TRACKING */
    void EnemyMovementPatrolV1()
    {
        transform.Translate(_moving * enemyMoveSpeed * Time.deltaTime);

        if (transform.position.x <= enemyPosLeft)
        {
            _moving = Vector2.right;
        }

        else if(transform.position.x >= enemyPosRight)
        {
            _moving = Vector2.left;
        }
    }

    void EnemyMovementPatrolV2()
    {
        if(patrolNow)
        {
            transform.Translate(_moving * enemyMoveSpeed * Time.deltaTime);
        }
        
    }


    /* ENEMY RAYCAST SYSTEM */
    private void EnemyRaycastDetection()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, playerDirection, rayDistance, layerMask);

        Debug.DrawRay(transform.position, playerDirection * rayDistance, Color.red);

        if (hit)
        {
            Debug.Log("Hit!");
            EnemyMovementFollow();
        }
    }


    /* TRIGGER THIS TO START FOLLOWING THE PLAYER */
    void EnemyMovementFollow()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, Time.deltaTime * 2);
    }

    IEnumerator EnemyPatrolTrigger()
    {
        yield return new WaitForSeconds(1f);
        patrolNow = true;
    }
   

}
