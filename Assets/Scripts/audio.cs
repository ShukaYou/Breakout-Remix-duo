using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class audio : MonoBehaviour
{
   
    public AudioClip laser;
    AudioSource audioSource;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Ball")
        {
            UnityEngine.Debug.Log("bruh momento");
            audioSource.PlayOneShot(laser, 0.5F);
        }
       
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
