﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

	public static float movementSpeed = 0.5f;

	void Start () {
	}

	void FixedUpdate()
	{
		Vector3 currentPosition = transform.position;
		transform.position = new Vector3(currentPosition.x , currentPosition.y,
			currentPosition.z - movementSpeed);
	}
}
