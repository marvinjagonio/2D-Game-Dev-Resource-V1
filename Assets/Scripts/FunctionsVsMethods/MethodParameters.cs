using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodParameters : MonoBehaviour
{
    public int PlayerHealth;
    private void Start()
    {
        Sum(5, 3);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerDamage(5);
        }

    }

    private void Sum(int a, int b)
    {
        Debug.Log(a + b);
    }

    private void PlayerDamage(int damageAmount)
    {
        PlayerHealth -= damageAmount;
    }
}
