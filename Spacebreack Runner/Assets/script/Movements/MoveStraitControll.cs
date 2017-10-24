using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraitControll : MonoBehaviour {

	public Vector3 velocity;


	void FixedUpdate()
	{
		GetComponent<Rigidbody>().velocity = velocity;
	}
}
