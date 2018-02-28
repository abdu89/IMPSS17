using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Touch : MonoBehaviour 
{
    Rigidbody body;
    private float speed = 0.09F;

    void Start()
    {

        body = GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector3 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            transform.Translate(touchDeltaPosition.x * speed, touchDeltaPosition.y * speed, 0);
        }
    }

    



}

