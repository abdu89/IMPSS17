using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBirdMovement : MonoBehaviour {

	//public float x;
	//public float z;
	public Vector3 jumpForce;
	public Vector3 leftForce;
	public Vector3 righForce;
	private Rigidbody rb;
	private Rigidbody rc;

	void Start () {
		rb=GetComponent<Rigidbody> ();

	}

	void Update () {
		
		if (Input.GetButtonDown ("Jump")) {
			
			Debug.Log (jumpForce);
			rb.AddForce (jumpForce * Time.timeScale);
		}

		if (Input.GetButtonDown ("Horizontal")) {

			Debug.Log (leftForce);
			rb.AddForce (leftForce * Time.timeScale);
		}

		if (Input.GetButtonDown ("Vertical")) {

			Debug.Log (righForce);
			rb.AddForce (righForce * Time.timeScale);
		}



		//var x = Input.GetAxis("Horizontal") * Time.deltaTime * 20.0f;
		//var z = Input.GetAxis("Vertical") * Time.deltaTime * 190.0f;

	 // transform.position = new Vector3(2, z, x);
		//transform.Translate(2, z, 0);




		
	}


}
