using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouch : MonoBehaviour
{
	Rigidbody body;
	public float speed = 10.0F;

	void Start () {

		body = GetComponent <Rigidbody> ();

	}

	void Update()
	{
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
		{
			Vector3 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

			transform.Translate(0,touchDeltaPosition.y * speed, -touchDeltaPosition.x * speed);
		}
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "wand")
        {
            transform.position = new Vector3(0, 0, 0);
            print(transform.position.x);
            body.AddForce(Vector3.right * 30);
        }
    }

}
