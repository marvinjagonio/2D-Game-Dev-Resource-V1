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
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * 5 * Time.deltaTime);
            flipFollow.localPosition = new Vector2(-offset, flipFollow.localPosition.y);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * 5 * Time.deltaTime);
            flipFollow.localPosition = new Vector2(offset, flipFollow.localPosition.y);
        }
    }
}
