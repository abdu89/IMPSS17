using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooting : MonoBehaviour {

    float bulletSpeed = 1100f;
    public GameObject bullet;
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
        Destroy(tempBullet, 0.5f);

        //Play Audio
        bulletAudio.Play();

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
}