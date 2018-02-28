using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour {


	void Start () {
	}

	public  void sceneChangeTo (string change) {
		SceneManager.LoadScene(change);
	}
}
