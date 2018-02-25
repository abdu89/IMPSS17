using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour {

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
			counterMax = Random.Range (10, 20);
			//Spawn cube here
			GameObject t = Instantiate (toSpawn, new Vector3 (Random.Range (45, 60), Random.Range (-1, 10), Random.Range (66, 200)), Quaternion.identity);
			Destroy (t, 15f);
			Debug.Log (t);
            t.GetComponent<AsteroidMovement>().movementSpeed = Random.Range(0.4f, 2.4f);
        }
	

	}
		
	void DestroyComponent()
	{
		Destroy(GetComponent<Rigidbody>());
	}

}


 