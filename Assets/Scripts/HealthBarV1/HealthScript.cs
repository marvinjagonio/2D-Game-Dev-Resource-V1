using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public Image healthSlider;
    public float playerHealth = 100f;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            PlayerDamage(10);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            PlayerHeal(10);
        }


    }

    public void PlayerDamage(float damage)
    {
        playerHealth -= damage;
        healthSlider.fillAmount = playerHealth / 100f;
    }    

    public void PlayerHeal(float healing)
    {
        playerHealth += healing;
        playerHealth = Mathf.Clamp(playerHealth, 0, 100);

        healthSlider.fillAmount = playerHealth / 100f;
    }
}
