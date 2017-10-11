using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyColisionChecker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("triggered");
	}

	void OnCollisionEnter(Collision collision)
	{
		Debug.Log ("collision");
		Time.timeScale = 0f;
	}
}
