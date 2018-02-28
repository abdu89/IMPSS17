using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControl : MonoBehaviour {


	Rigidbody body;
    float playerSpeed = 200;

    void Start () {

		body = GetComponent <Rigidbody> ();

	}

	void Update () {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            body.AddForce(Vector3.left * playerSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            body.AddForce(Vector3.right * playerSpeed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            body.AddForce(Vector3.up * playerSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            body.AddForce(Vector3.down * playerSpeed);
        }
	}
}

