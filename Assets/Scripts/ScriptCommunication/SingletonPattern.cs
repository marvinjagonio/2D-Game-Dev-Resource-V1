using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonPattern : MonoBehaviour
{
    public static SingletonPattern Instance { get; private set; }

    public bool IsPlayerAlive;
    public int PlayerLevel;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }

        else
        {
            Instance = this;
        }
    }



    private void Start()
    {
        
    }
}
