using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpawner : MonoBehaviour {

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
			counter = 0;
			counterMax = Random.Range (180, 220);
			GameObject t = Instantiate (toSpawn, new Vector3 (Random.Range (48, 58), Random.Range (-1, 10),Random.Range (0, 300)), Quaternion.identity);
			Destroy (t, 20f);
			Debug.Log (t);
            //t.GetComponent<LiveMovement>().movementSpeed = Random.Range(0.4f, 4.4f);
        }

	}

}
