using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

		Rigidbody body;
		// Use this for initialization
		void Start () {

			body = GetComponent <Rigidbody> ();

		}

		// Update is called once per frame
		void Update () {

			if (Input.GetKey (KeyCode.LeftArrow))
				body.AddForce (Vector3.left * 10);
			if (Input.GetKey (KeyCode.RightArrow))
				body.AddForce (Vector3.right* 10);
			if (Input.GetKey (KeyCode.UpArrow))
				body.AddForce (Vector3.up * 10);
		}
	}

