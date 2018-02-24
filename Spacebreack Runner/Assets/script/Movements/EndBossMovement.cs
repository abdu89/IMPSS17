using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBossMovement : MonoBehaviour {

	public Transform player;

	public float movementSpeed = 0.01f;


	void Start () {

	}

	void Update(){
		this.transform.rotation = Quaternion.LookRotation (transform.position - player.transform.position);

	}

    void FixedUpdate()
    {
		
        Vector3 currentPosition = transform.position;
        transform.position = new Vector3(movementSpeed, movementSpeed,
            movementSpeed);
    }


}
