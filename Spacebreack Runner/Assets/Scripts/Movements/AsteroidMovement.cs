using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour {

	public Transform player;

	public float movementSpeed = 10.0f;

	void Start () {
	}

	void Update(){
		this.transform.rotation = Quaternion.LookRotation (transform.position - player.transform.position);

	}

    void FixedUpdate()
    {
		
		Vector3 currentPosition = transform.position;
        transform.position = new Vector3(currentPosition.x, currentPosition.y,
            currentPosition.z - movementSpeed);
    }


}
