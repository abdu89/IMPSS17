using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakSpawner : MonoBehaviour {

	public GameObject toSpawn;
	private int counter = 0;
	private int counterMax = 800;
	private int spawnMin, spawnMax;

	void Start () {
        Time.timeScale = 1;
    }
		
	void FixedUpdate () {
		counter++;
		if (counter == counterMax) {

			int radom = Random.Range (spawnMin, spawnMax);

			counter = 0;
			counterMax = Random.Range (180, 350);
			//Spawn cube here
			GameObject t = Instantiate (toSpawn, new Vector3 (Random.Range (48, 58), Random.Range (1, 9),Random.Range (0, 300)), Quaternion.identity);
			Destroy (t, 30f);
			Debug.Log (t);
            t.GetComponent<LiveMovement>().movementSpeed = Random.Range(0.4f, 1.4f);
        }

	}

}
