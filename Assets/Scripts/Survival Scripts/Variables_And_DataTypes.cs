using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables_And_DataTypes : MonoBehaviour
{
    //[SerializeField] to make it private but still modify it in inspector
    //public - to make it visible in inspector and access by other script
    //private - only accesible inside the class

    //*NAMING CONVENTION*
    //private field - _lowerCamelCase
    //public field - UpperCamelCase
    //protected field - UpperCamelCase
    //internal field - UpperCamelCase
    //property - UpperCamelCase
    //method - UpperCamelCase
    //class - UpperCamelCase
    //interface - IUpperCamelCase
    //local variable - lowerCamelCase
    //parameter - lowerCamelCase


    //*COMMON DATA TYPES*
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
