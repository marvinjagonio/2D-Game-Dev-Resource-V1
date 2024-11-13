using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operators : MonoBehaviour
{
    public int x = 10;
    public int y = 3;

    private void Start()
    {
        AssignmentOperatorsSample();
    }

    private void ArithmeticOperatorsSample()
    {
        Debug.Log(x + y);
        Debug.Log(x - y);
        Debug.Log(x * y);
        Debug.Log(x / y);
        Debug.Log(x % y);

        Debug.Log(x++);
        Debug.Log(++x);

        Debug.Log(x--);
        Debug.Log(--x);
    }

    private void AssignmentOperatorsSample()
    {
        //Assignment Operator =
        //Compound Assignment Operator +=
        
        x = x + 5;
        x += 5;

        Debug.Log(x);
    }

    private void ComparisonOperatorsSample()
    {
        Debug.Log(x > 0);
        Debug.Log(x >= 0);
        Debug.Log(x < 0);
        Debug.Log(x <= 0);

        Debug.Log(x == 1);
        Debug.Log(x != 1);
        //== equalilty comparison
        //= assignment
        //&& AND Operator - all should be true
        //|| OR Operator - atleast one is true
    }

}
