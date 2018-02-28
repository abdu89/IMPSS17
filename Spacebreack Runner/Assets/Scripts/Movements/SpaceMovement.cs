using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceMovement : MonoBehaviour {

	public static float movementSpeed = 0.089f;
	//public float lifeTime = 6f

	void Start () {
	}

	void FixedUpdate()
	{
		Vector3 currentPosition = transform.position;
		transform.position = new Vector3(currentPosition.x - movementSpeed, currentPosition.y,
			currentPosition.z - movementSpeed);
	}
}
