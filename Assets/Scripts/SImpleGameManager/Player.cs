using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int points = 10;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.AddScore(points);
                
            }
        }
        
    }
}
