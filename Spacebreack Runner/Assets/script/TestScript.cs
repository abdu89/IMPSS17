using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {


	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetButtonDown ("Jump")) {
			//Vector3 oldPosition = transform.position;
			//transform.position = new Vector3 (oldPosition.x + 0.4f, oldPosition.y, oldPosition.z);
			//rb.AddForce (new Vector3 (0, force, 0));

		}
	}
}
