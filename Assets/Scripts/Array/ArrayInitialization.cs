using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class ArrayInitialization : MonoBehaviour
{
    //Standard declaration
    public string[] PlayerNames;
    public int[] numbers = new int[5];

    //Declaration with initialization
    public int[] WeaponID = {1,2,3,4,5};
    public string[] WeaponsName = { "sword","axe","knife","spear","bow"};

    //Using the new keyword
    float[] positions = new float[] { 1.5f, 2.5f, 3.5f };

    //Declaring an array using gameobjects
    public GameObject[] gameObjects;
    public GameObject[] gameObjects2 = new GameObject[5];

    //randomizer variable
    private int Randomizer;

    private void Awake()
    {
        //randomizer initialization
        Randomizer = Random.Range(0,WeaponID.Length);
    }

    void Start()
    {
        //accessing single content of an array
        Debug.Log(WeaponID[2]);

        //accessing all of the content using for loop
        for (int i = 0; i < WeaponID.Length; i++)
        {
            Debug.Log(WeaponID[i]);
        }


        //accessing an array using while loop
        int j = 0;
        while(j < WeaponsName.Length)
        {
            Debug.Log (WeaponID[j]);
            j++;
        }

        //accessing array using foreach loop
        foreach(var coordinateLoc in positions)
        {
            Debug.Log(coordinateLoc);
        }

        //accessing array using random number
        Debug.Log(WeaponsName[Randomizer]);


        for (int i = 0; i < WeaponsName.Length; i++)
        {
            if(WeaponsName[i] == "axe" )
            {
                Debug.Log(WeaponsName[i]);
                break;
            }
        }
    }

    
    void Update()
    {
        
    }
}
