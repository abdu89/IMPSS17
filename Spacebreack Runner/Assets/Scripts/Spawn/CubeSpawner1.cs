using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner1 : MonoBehaviour {

    public GameObject toSpawn;

	public int counter = 0;
	void Start () {
		
	}
	
	void Update () {
        counter++;
        if( counter == 60)
        {
            counter = 1;
            //Spawn cube here
            Instantiate(toSpawn, new Vector3(0, 5, 0), Quaternion.identity);
        }
	}
}
