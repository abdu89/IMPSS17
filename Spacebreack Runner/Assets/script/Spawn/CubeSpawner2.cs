using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner2 : MonoBehaviour {

    public GameObject toSpawn;

    private int counter = 0;
	void Start () {
		
	}
	
	void Update () {
        counter++;
        if( counter == 60)
        {
            counter = 0;
            //Spawn cube here
            Instantiate(toSpawn, new Vector3(0, 20, 0), Quaternion.identity);
        }
        
	}
}
