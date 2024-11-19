using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlippingChildObject : MonoBehaviour
{
    public Transform flipFollow;
    public float offset;
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            flipFollow.localPosition = new Vector2(-offset, flipFollow.localPosition.y);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            flipFollow.localPosition = new Vector2(offset, flipFollow.localPosition.y);
        }
    }
}
