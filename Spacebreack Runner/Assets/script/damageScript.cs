using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageScript : MonoBehaviour {

	public GameObject damagePanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void takeDamage(){
		Time.timeScale = 0;
		//Cursor.lockState = CursorLockMode.None;
		//Cursor.visible = true;
		AsteroidMovement.movementSpeed = 1;

		damagePanel.SetActive (false);
		damagePanel.SetActive (true);
	}
}
