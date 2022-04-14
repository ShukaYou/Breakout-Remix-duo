using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class WallLeftCollision : MonoBehaviour
{
    //public BallMovement restart;
    public GameManager yo;
    public AudioClip laser;
    AudioSource audioSource;
    void OnCollisionEnter2D (Collision2D Ball)
    {
        UnityEngine.Debug.Log("BAM LEFTY HAS BEEN HIT MAYDAY");
       
         Ball.gameObject.transform.position = new Vector3(0.0f, 0.0f, 0.0f);

         audioSource.PlayOneShot(laser, 0.7F);
         yo.updateLives(-1);
       // restart.GoBall(0, 4f);

        }



    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
}
