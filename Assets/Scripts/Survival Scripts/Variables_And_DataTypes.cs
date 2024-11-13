using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables_And_DataTypes : MonoBehaviour
{
    //Common Data Types

    public int score = 25;
    public float speed = 3.1415927f;
    public double gold = 3.141592653589793;

    public string characterName = "Marvin";
    public char characterInitial = 'a';

    public bool isAttacking = false;

    public GameObject player;
    public Animator playerAnim;
    public Transform myTransform;

    public Rigidbody2D playerRB;
    public Vector2 playerPosition;
    public Vector3 playerPosition3D;

    public Color playerColor = Color.red;
    public Quaternion playerRotation;
    public LayerMask collisionLayer;
    public List<GameObject> enemies;
    public Dictionary<string, int> itemInventory = new Dictionary<string, int>();


}
