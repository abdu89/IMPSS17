using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	private Transform target;
	private Vector3 offset;
	private Vector3 moveVector;

	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player").transform;
		offset = transform.position - target.position;
		
	}
	
	void LateUpdate () {
		moveVector = target.position + offset;

		transform.position = moveVector;

	}
}
