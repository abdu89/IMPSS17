using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakSpawner : MonoBehaviour {

	public GameObject toSpawn;
	private int counter = 0;
	private int counterMax = 800;
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
			counterMax = Random.Range (180, 350);
			//Spawn cube herer
			GameObject t = Instantiate (toSpawn, new Vector3 (Random.Range (48, 58), Random.Range (1, 10),Random.Range (0, 300)), Quaternion.identity);
			Destroy (t, 30f);
			Debug.Log (t);
		}

	}

}
