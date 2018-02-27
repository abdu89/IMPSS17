using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    public int scoreValue = 1;
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
            ScoreNum.score += scoreValue;
            Destroy(collision.gameObject);
            collisionAudio.Play();
            gameObject.SetActive(false);
        }
    }
}
