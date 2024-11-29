using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private int playerScore = 0;

    private void Awake()
    {
        //ENSURE ONLY ONE GAMEMANAGER EXISTS (SINGLETON PATTERN)
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); //KEEPS THE GAMEMANAGER ACROSS SCENES
        }

        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int points)
    {
        playerScore += points;
        Debug.Log("Player Score: " + playerScore);
    }

    public int GetScore()
    {
        return playerScore;
    }
}
