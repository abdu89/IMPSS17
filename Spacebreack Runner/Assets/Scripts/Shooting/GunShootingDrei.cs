﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShootingDrei : MonoBehaviour {

    float bulletSpeed = 1300f;
    public GameObject bullet;
	private int counter = 0;
	private int counterMax = 100;
    AudioSource bulletAudio;

    void Start()
    {

        bulletAudio = GetComponent<AudioSource>();
    }

    void Fire()
    {

        //Shoot
        GameObject tempBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
        Rigidbody tempRB = tempBullet.GetComponent<Rigidbody>();
        tempRB.AddForce(tempRB.transform.forward * bulletSpeed);
        Destroy(tempBullet, 10.0f);

        //Play Audio
        bulletAudio.Play();

    }


    void Update()
    {
    }


	void FixedUpdate () {
		counter++;
		Debug.Log (counter);


		if (counter == counterMax) {

			counter = 0;
			counterMax = Random.Range (20, 40);
			Fire();
		}
			
	}
		
}