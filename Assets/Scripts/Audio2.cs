using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Audio2 : MonoBehaviour
{

    public AudioClip laser;
    AudioSource audioSource;
    void OnTriggerEnter2D(Collider2D other)
    {
        audioSource.PlayOneShot(laser, 0.7F);
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
