using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPause : MonoBehaviour {

	public GameObject pauseButton;
	public GameObject onPausePanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PauseIsPressed(){
		Time.timeScale = 0;
		//Cursor.lockState = CursorLockMode.None;
		//Cursor.visible = true;
		AsteroidMovement.movementSpeed = 0;

		pauseButton.SetActive (false);
		onPausePanel.SetActive (true);
	}

	public void ResumeIsPressed(){
		Time.timeScale = 1;
		//Cursor.lockState = CursorLockMode.None;
		//Cursor.visible = true;
		AsteroidMovement.movementSpeed = 0.05f;

		pauseButton.SetActive (true);
		onPausePanel.SetActive (false);
	}
}
