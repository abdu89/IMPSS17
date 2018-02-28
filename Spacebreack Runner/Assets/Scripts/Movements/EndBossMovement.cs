using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBossMovement : MonoBehaviour {
    private int counter = 0;
    private int counterMax = 400;

    public Transform player;

	public float movementSpeed = 0.01f;

	void Start () {
	}

	void Update(){
        counter++;
        Debug.Log(counter);

        if (counter == 1000)
        {
        counter = 0;
        }
             
        if (counter <= 40)
        {
            Vector3 currentPosition = transform.position;
            transform.position = new Vector3(currentPosition.x - movementSpeed, currentPosition.y,
                currentPosition.z);

            movementSpeed = Random.Range(0.01f, 0.15f);
        }
        if (counter >= 30 && counter <= 60)
        {
            Vector3 currentPosition = transform.position;
            transform.position = new Vector3(currentPosition.x, currentPosition.y - -movementSpeed,
                currentPosition.z);
            movementSpeed = Random.Range(0.01f, 0.15f);
        }


      


        if (counter >= 100 && counter <= 150)
        {
            Vector3 currentPosition = transform.position;
            transform.position = new Vector3(currentPosition.x - -movementSpeed, currentPosition.y,
                currentPosition.z);
            movementSpeed = Random.Range(0.01f, 0.15f);
        }
        if (counter >= 130 && counter <= 180)
        {
            Vector3 currentPosition = transform.position;
            transform.position = new Vector3(currentPosition.x, currentPosition.y - movementSpeed,
                currentPosition.z);
            movementSpeed = Random.Range(0.01f, 0.15f);
        }




        if (counter >= 270 && counter <= 330)
        {
            movementSpeed = Random.Range(0.01f, 0.15f);
            Vector3 currentPosition = transform.position;
            transform.position = new Vector3(currentPosition.x, currentPosition.y,
                currentPosition.z - -movementSpeed);

        }




        if (counter >= 430  && counter <= 530)
        {
            Vector3 currentPosition = transform.position;
            transform.position = new Vector3(currentPosition.x - movementSpeed, currentPosition.y,
                currentPosition.z);

            movementSpeed = Random.Range(0.01f, 0.15f);
        }
        if (counter >= 500 && counter <= 540)
        {
            Vector3 currentPosition = transform.position;
            transform.position = new Vector3(currentPosition.x, currentPosition.y - -movementSpeed,
                currentPosition.z);
            movementSpeed = Random.Range(0.01f, 0.15f);
        }


        if (counter >= 540 && counter <= 640)
        {
            Vector3 currentPosition = transform.position;
            transform.position = new Vector3(currentPosition.x - -movementSpeed, currentPosition.y,
                currentPosition.z);
            movementSpeed = Random.Range(0.01f, 0.15f);
        }

        if (counter >= 530 && counter <= 670)
        {
            Vector3 currentPosition = transform.position;
            transform.position = new Vector3(currentPosition.x, currentPosition.y - movementSpeed,
                currentPosition.z);
            movementSpeed = Random.Range(0.01f, 0.15f);
        }



        if (counter >= 740 && counter <= 840)
        {
            Vector3 currentPosition = transform.position;
            transform.position = new Vector3(currentPosition.x, currentPosition.y,
                currentPosition.z - movementSpeed);
        }
    }
}
