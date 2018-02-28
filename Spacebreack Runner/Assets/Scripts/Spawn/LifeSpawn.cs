using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpawn : MonoBehaviour
{

    public GameObject toSpawn;
    private int counter = 0;
    private int counterMax = 500;
    private int spawnMin, spawnMax;

    void Start()
    {
        Time.timeScale = 1;
    }

    void FixedUpdate()
    {
        counter++;
        Debug.Log(counter);


        if (counter == counterMax)
        {

            int radom = Random.Range(spawnMin, spawnMax);

            counter = 0;
            counterMax = 500;
            //Spawn cube here
            GameObject t = Instantiate(toSpawn, new Vector3(Random.Range(45, 60), Random.Range(0, 10), Random.Range(55, 200)), Quaternion.identity);
            Destroy(t, 50f);
            Debug.Log(t);
            t.GetComponent<LiveMovement>().movementSpeed = Random.Range(0.2f, 1.0f);
        }


    }
}