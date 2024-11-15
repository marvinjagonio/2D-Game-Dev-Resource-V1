using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingColor : MonoBehaviour
{
    [SerializeField] GameObject triangle;
    private SpriteRenderer triangleRenderer;

    private int _nextColor;

    private void Start()
    {
        triangleRenderer = GetComponent<SpriteRenderer>();
        Debug.Log(_nextColor);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            _nextColor = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _nextColor = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _nextColor = 3;
        }


        switch(_nextColor)
        {
            case 1:
                triangleRenderer.color = Color.red;
                //triangle.GetComponent<SpriteRenderer>().color = Color.red;
                break;

            case 2:
                triangleRenderer.color = Color.blue;
                //triangle.GetComponent<SpriteRenderer>().color = Color.red;
                break;

            case 3:
                triangleRenderer.color = Color.yellow;
                //triangle.GetComponent<SpriteRenderer>().color = Color.red;
                break;

            default:
                triangleRenderer.color = Color.white;
                break;

        }


    }
}
