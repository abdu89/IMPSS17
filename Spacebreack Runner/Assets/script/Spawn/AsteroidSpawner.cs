using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour {

	public GameObject toSpawn;
	private int counter = 0;
	private int counterMax = 15;
	private int spawnMin, spawnMax;

	//public Vector3 SpawnPosition;

	void Start () {
		Time.timeScale = 1;
	}
		
	// Update is called once per frame
	void FixedUpdate () {
		counter++;
		Debug.Log (counter);


		if (counter == counterMax) {

			int radom = Random.Range (spawnMin, spawnMax);

			counter = 0;
			counterMax = Random.Range (2, 15);
			//Spawn cube herer
			GameObject t = Instantiate (toSpawn, new Vector3 (Random.Range (48, 63), Random.Range (-2, 9), Random.Range (66, 300)), Quaternion.identity);
			Destroy (t, 15f);
			Debug.Log (t);
			t.GetComponent<AsteroidMovement> ().movementSpeed = Random.Range (0.1f, 5.0f);
		}
	

	}
		
	void DestroyComponent()
	{
		// Removes the rigidbody from the game object
		Destroy(GetComponent<Rigidbody>());
	}

}


 