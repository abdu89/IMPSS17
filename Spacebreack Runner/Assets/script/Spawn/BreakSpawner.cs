using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakSpawner : MonoBehaviour {

	public GameObject toSpawn;
	private int counter = 0;
	private int counterMax = 200;
	private int spawnMin, spawnMax;

	//public Vector3 SpawnPosition;

	void Start () {
		
	}
		
	// Update is called once per frame
	void FixedUpdate () {
		counter++;
		//Debug.Log (counter);
		if (counter == counterMax) {

			int radom = Random.Range (spawnMin, spawnMax);

			counter = 0;
			counterMax = Random.Range (55, 190);
			//Spawn cube herer
			GameObject t = Instantiate (toSpawn, new Vector3 (Random.Range (50, 60), Random.Range (1, 5),Random.Range (10, 200)), Quaternion.identity);
			Destroy (t, 30f);
			Debug.Log (t);
		}

	}

}
