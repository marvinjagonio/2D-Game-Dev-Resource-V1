using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingReturnType : MonoBehaviour
{
    private int total;
    private int total2;
    void Start()
    {
        total = Sum(38, 12);
        total2 = Sum(12, 49);

        Debug.Log(total + " " + total2);
    }


    void Update()
    {

    }
    private int Sum(int a, int b)
    {
        return a + b;
    }
}
