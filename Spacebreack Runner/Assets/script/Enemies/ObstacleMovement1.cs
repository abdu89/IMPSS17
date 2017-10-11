using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement1 : MonoBehaviour {

	public static float movementSpeed = 0.4f;
    //public float lifeTime = 6f;

	void Start () {
        //Destroy(gameObject, lifeTime);
	}

    void FixedUpdate()
    {
        Vector3 currentPosition = transform.position;
        transform.position = new Vector3(currentPosition.x - movementSpeed, currentPosition.y,
            currentPosition.z);
    }


}
