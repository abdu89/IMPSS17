using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    AudioSource collisionAudio;
    
    void Start()
    {
        collisionAudio = GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.tag == "as")
        {
            Destroy(collision.gameObject);
            collisionAudio.Play();
            gameObject.SetActive(false);
        }
    }
}
