using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour {

	public GameObject toSpawn;
	private int counter = 0;
	private int counterMax = 40;
	//private int spawnMin, spawnMax;

	//public Vector3 SpawnPosition;

	void Start () {
		
	}
		
	// Update is called once per frame
	void FixedUpdate () {
		counter++;
		//Debug.Log (counter);
		if (counter == counterMax) {

			//int radom = Random.Range (spawnMin, spawnMax);

			counter = 0;
			counterMax = Random.Range (8,15);
			//Spawn cube herer
			GameObject t = Instantiate (toSpawn, new Vector3 (60, Random.Range (1,9), Random.Range (0, 8)), Quaternion.identity);
			Destroy (t, 30f);
			//Debug.Log (t);
		}

	}

}
 