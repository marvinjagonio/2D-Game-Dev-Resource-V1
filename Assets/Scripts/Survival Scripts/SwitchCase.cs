using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCase : MonoBehaviour
{
    public int levelSelect;

    private void Start()
    {

    }

    private void Update()
    {

        switch (levelSelect)
        {
            case 1:
                Debug.Log("You have selected level 1");
                break;

            case 2:
                Debug.Log("You have selected level 2");
                break;

            case 3:
                Debug.Log("You have selected level 3");
                break;

            default:
                Debug.Log("That selection is not available");
                break;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            levelSelect = Random.Range(0, 3);
        }
    }

    
}
