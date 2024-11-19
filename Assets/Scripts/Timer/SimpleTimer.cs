using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SimpleTimer : MonoBehaviour
{
    public int CountDownTimer;
    public Text text;
    public TextMeshProUGUI textTimer;

    private void Start()
    {
        StartCoroutine(StartCountDown());
    }

    private void Update()
    {
        text.text =  CountDownTimer.ToString();
        textTimer.text = CountDownTimer.ToString();
    }


    private IEnumerator StartCountDown()
    {
            while (CountDownTimer > 0)
            {
                yield return new WaitForSeconds(1f);
                CountDownTimer--;
            }
           
    }
}
