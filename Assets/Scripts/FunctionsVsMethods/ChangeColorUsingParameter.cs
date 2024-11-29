using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorUsingParameter : MonoBehaviour
{
    [SerializeField] GameObject playerObject;

    SpriteRenderer playerChangeColor;
   
   
    void Start()
    {
        playerChangeColor = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            ChangeObjectColor(playerObject, Color.red);
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            ChangeObjectColor2(playerChangeColor, Color.red);
        }


    }

    private void ChangeObjectColor(GameObject playerObj, Color ColorToAssign)
    {
        playerObject.GetComponent<SpriteRenderer>().color = ColorToAssign;

        
    }

    private void ChangeObjectColor2(SpriteRenderer playerObj2, Color ColorToAssign2)
    {
        playerObj2.color = ColorToAssign2;
    }
}
