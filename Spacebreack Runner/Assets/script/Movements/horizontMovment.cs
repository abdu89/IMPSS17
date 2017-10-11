using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontMovment : MonoBehaviour {

	void Start () {

	}

	void Update()
	{
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 190.0f;
		//var z = Input.GetAxis("Horizontal") * Time.deltaTime * -190.0f;

		transform.position = new Vector3(0, 0, x);
		transform.Translate(0, 0, x);
	}

}
