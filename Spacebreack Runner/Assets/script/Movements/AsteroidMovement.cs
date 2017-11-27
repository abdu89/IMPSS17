using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour {

	public Transform player;

	public float movementSpeed = 10.0f;
    //public float lifeTime = 6f;

	void Start () {
        //Destroy(gameObject, lifeTime);

	}

	void Update(){
		this.transform.rotation = Quaternion.LookRotation (transform.position - player.transform.position);

	}

    void FixedUpdate()
    {
		
		//movementSpeed=Random.Range(1.0f,5.0f);
        Vector3 currentPosition = transform.position;
        transform.position = new Vector3(currentPosition.x, currentPosition.y,
			currentPosition.z - movementSpeed);
    }


}
