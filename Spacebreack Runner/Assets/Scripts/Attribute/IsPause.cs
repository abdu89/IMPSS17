using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPause : MonoBehaviour {

	public GameObject pauseButton;
	public GameObject onPausePanel;

	void Start () {
	}
	
	void Update () {
	}

	public void PauseIsPressed(){
		Time.timeScale = 0;

		pauseButton.SetActive (false);
		onPausePanel.SetActive (true);
	}

	public void ResumeIsPressed(){
		Time.timeScale = 1;

		pauseButton.SetActive (true);
		onPausePanel.SetActive (false);
	}
}
