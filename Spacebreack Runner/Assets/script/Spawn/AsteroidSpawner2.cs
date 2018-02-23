using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner2 : MonoBehaviour {

	public GameObject toSpawn;
	private int counter = 0;
	private int counterMax = 20;
	private int spawnMin, spawnMax;

	void Start () {
		Time.timeScale = 1;
	}

	void FixedUpdate () {
		counter++;
		Debug.Log (counter);


		if (counter == counterMax) {

			int radom = Random.Range (spawnMin, spawnMax);

			counter = 0;
			counterMax = Random.Range (1, 12);
			//Spawn cube here
			GameObject t = Instantiate (toSpawn, new Vector3 (Random.Range (45, 68), Random.Range (-2, 10), Random.Range (66, 300)), Quaternion.identity);
			Destroy (t, 15f);
			Debug.Log (t);
			t.GetComponent<AsteroidMovement> ().movementSpeed = Random.Range (0.4f, 2.4f);
		}


	}

	void DestroyComponent()
	{
		Destroy(GetComponent<Rigidbody>());
	}

}