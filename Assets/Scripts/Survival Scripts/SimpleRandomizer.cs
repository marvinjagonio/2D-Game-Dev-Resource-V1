using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRandomizer : MonoBehaviour
{
    public float score1, score2, score3;

    private void Start()
    {
        score1 = Random.Range(0f, 10f);
        score2 = Random.Range(0f, 10f);
        score3 = Random.Range(0f, 10f);

        float overallScore = (score1 + score2 + score3) / 3;

        //to round it up
        overallScore = Mathf.Round(overallScore * 100f) / 1000f;

        Debug.Log("Your overall Score is :" + overallScore);

    }
}
