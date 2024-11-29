using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptA : MonoBehaviour
{
    [SerializeField] ScriptObj sObj;
    [SerializeField] ScriptB accessScriptB;
    ScriptC scriptC;
    ScriptD scriptD;

   
    void Start()
    {
        
        //Simple variable access
        accessScriptB.PlayerScore = 15;
        Debug.Log(accessScriptB.PlayerScore);

        //Accessing function and feeding the parameter
        accessScriptB.PowerLevel(100);

        //Checking ther variable using conditional statement
        if (accessScriptB.PlayerStamina >= 5)
        {
            Debug.Log("Player can run!");
        }

        //Access script by finding gameobject and getting the component
        scriptC = GameObject.Find("Player_C").GetComponent<ScriptC>();
        Debug.Log(scriptC.TotalGoldCoins);

        //Access script by finding gameobject by its tag and access the component
        scriptD = GameObject.FindGameObjectWithTag("Player_D").GetComponent<ScriptD>();
        Debug.Log(scriptD.IsPlayerAlive);

        //Access script using static variable
        StaticVariables.TotalEnemyKilled = 50;
        Debug.Log(StaticVariables.TotalEnemyKilled);

        //Access script using Singleton Pattern
        SingletonPattern.Instance.IsPlayerAlive = true;
        Debug.Log(SingletonPattern.Instance.IsPlayerAlive);
        Debug.Log(SingletonPattern.Instance.PlayerLevel);

        //Access script using Scriptable Objects
        int PlayerScore = sObj.TotalScore = 99;
        int PlayerTotalCrystals= sObj.TotalCrystalCollected = 55;
        Debug.Log(PlayerScore + " " + PlayerTotalCrystals);

        //Access script inside the child gameobject /* SAMPLE SCRIPT ONLY, DO NOT UNCOMMENT */
        //animator = GetComponentInChildren<Animator>();

        
    }

   
    void Update()
    {
       
    }
}
