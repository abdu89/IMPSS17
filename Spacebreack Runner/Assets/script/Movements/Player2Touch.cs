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
            // Get movement of the finger since last frame
            Vector3 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            // Move object across XY plane
            transform.Translate(touchDeltaPosition.x * speed, touchDeltaPosition.y * speed, 0);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "wand")
        {
            transform.position = new Vector3(53.25F, 3.89F, -18.48F);
            print(transform.position.x);
            //body.AddForce(Vector3.right * 30);
        }
    }



}

