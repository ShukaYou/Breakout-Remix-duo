using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnContact : MonoBehaviour
{
    public AudioClip explosion;
    AudioSource Boom;


    void Start()
    {
        Boom = GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
       GameManager.score += 1;
        Boom.PlayOneShot(explosion, 2F);
        Invoke("destroyBrick", 0.05f);
        //Destroy(this.gameObject);
    }
    void destroyBrick()
    {
        Destroy(this.gameObject);
    }
}
