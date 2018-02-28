using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageScript : MonoBehaviour {

	public GameObject damagePanel;

	void Start () {
		
	}
	
	void Update () {
		
	}
	public void takeDamage(){
		Time.timeScale = 0;

		damagePanel.SetActive (false);
		damagePanel.SetActive (true);
	}
}
