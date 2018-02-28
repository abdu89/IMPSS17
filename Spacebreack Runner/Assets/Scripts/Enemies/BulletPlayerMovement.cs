using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayerMovement : MonoBehaviour {


	public static float movementSpeed = -0.4f;

	void Start () {
	}

	void FixedUpdate()
	{
		Vector3 currentPosition = transform.position;
		transform.position = new Vector3(currentPosition.x, currentPosition.y,
			currentPosition.z - movementSpeed);
	}
}
