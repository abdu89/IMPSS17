using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBossMovement : MonoBehaviour {
    private int counter = 0;
    private int counterMax = 400;

    public Transform player;

	public float movementSpeed = 0.01f;

	void Start () {
        //Destroy(gameObject, lifeTime);

	}

	void Update(){
        counter++;
        Debug.Log(counter);

        if (counter == 400)
        {
        counter = 0;
        }
             
        if (counter <= 80)
        {
            Vector3 currentPosition = transform.position;
            transform.position = new Vector3(currentPosition.x - movementSpeed, currentPosition.y,
                currentPosition.z);

            movementSpeed = Random.Range(0.1f, 0.1f);
        }
        if (counter >= 60 && counter <= 180)
        {
            Vector3 currentPosition = transform.position;
            transform.position = new Vector3(currentPosition.x, currentPosition.y - -movementSpeed,
                currentPosition.z);
            movementSpeed = Random.Range(0.1f, 0.3f);
        }
        if (counter >= 120 && counter <= 320)
        {
            Vector3 currentPosition = transform.position;
            transform.position = new Vector3(currentPosition.x - -movementSpeed, currentPosition.y,
                currentPosition.z);
            movementSpeed = Random.Range(0.1f, 0.3f);
        }
        if (counter >= 280 && counter <= 400)
        {
            Vector3 currentPosition = transform.position;
            transform.position = new Vector3(currentPosition.x, currentPosition.y - movementSpeed,
                currentPosition.z);
            movementSpeed = Random.Range(0.1f, 0.3f);
        }
       
    }

    /*public void OnTriggerEnter(Collider other)
    {
        counter++;
        Debug.Log(counter);
        if (counter <= 50)
        {

            if (other.gameObject.tag != "wand")
            {
                Vector3 currentPosition = transform.position;
                transform.position = new Vector3(currentPosition.x - movementSpeed, currentPosition.y,
                    currentPosition.z); ;
            }

            if (other.gameObject.tag == "wand")
            {
                transform.position = new Vector3(59.1F, 2.65F, -2.65F);
                print(transform.position.x);
            }
        }


        if (counter <= 200 && counter >= 100)
        {
            

            if (other.gameObject.tag != "wandCeiling")
            {
                Vector3 currentPosition = transform.position;
                transform.position = new Vector3(currentPosition.x, currentPosition.y - -movementSpeed,
                    currentPosition.z);
            }

            if (other.gameObject.tag == "wandCeiling")
            {
                counter = 0;
                transform.position = new Vector3(59.1F, 2.65F, -2.65F);
                print(transform.position.x);
            }
        }
    }*/
    }
