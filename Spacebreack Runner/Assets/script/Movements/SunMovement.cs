using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMovement : MonoBehaviour {

	public static float movementSpeed = 0.089f;
	//public float lifeTime = 6f

	void Start () {
		//Destroy(gameObject, lifeTime);
	}

	void FixedUpdate()
	{
		Vector3 currentPosition = transform.position;
		transform.position = new Vector3(currentPosition.x, currentPosition.y,
			currentPosition.z - movementSpeed);
	}


}
