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
			// Get movement of the finger since last frame
			Vector3 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

			// Move object across XY plane
			transform.Translate(0,touchDeltaPosition.y * speed, -touchDeltaPosition.x * speed);
		}
	}

}
