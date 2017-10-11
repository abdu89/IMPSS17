using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBirdObstacleSpawner : MonoBehaviour {

    public GameObject obstacle;
    public int counter_max = 60, spawnMin, spawnMax;
    public Vector3 spawnPosition;
    private int counter;

    void Start () {
		
	}
	
	void FixedUpdate () {

        counter++;
        if(counter == counter_max) {
            int random = Random.Range(spawnMin, spawnMax);
			Vector3 temp = new Vector3(spawnPosition.x + random, spawnPosition.y + random, spawnPosition.z + random);
            Instantiate(obstacle, temp, Quaternion.identity);
            counter = 0;
        }
		
	}
}
