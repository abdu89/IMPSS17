﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpawner : MonoBehaviour {

	public GameObject toSpawn;
	private int counter = 0;
	private int counterMax = 800;
	private int spawnMin, spawnMax;

	void Start () {
		
	}
		
	void FixedUpdate () {
		counter++;
		if (counter == counterMax) {
			counter = 0;
			counterMax = Random.Range (180, 220);
			GameObject t = Instantiate (toSpawn, new Vector3 (Random.Range (48, 58), Random.Range (-1, 10),Random.Range (0, 300)), Quaternion.identity);
			Destroy (t, 30f);
			Debug.Log (t);
		}

	}

}
