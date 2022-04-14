using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public KeyCode moveRight = KeyCode.D;
    public KeyCode moveLeft = KeyCode.A;

   public float speed = 4050.0f;
    //public AudioClip laser;
   // AudioSource audioSource;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {

        //audioSource.PlayOneShot(laser, 0.7F);
    }
    void Start()
    {
       // audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {  
            
            
        if (Input.GetKeyDown(moveRight) == true)
        {
            var vel = GetComponent<Rigidbody2D>().velocity;           //declaration of variable for velocity "vel"
            vel.x = 1 * speed;
            GetComponent<Rigidbody2D>().velocity = vel;

            UnityEngine.Debug.Log("Righty Has been pressed");
        }
        else if (Input.GetKeyDown(moveLeft) == true)
        {
            var vel = GetComponent<Rigidbody2D>().velocity;           //declaration of variable for velocity "vel"
            vel.x = -1 * speed;
            GetComponent<Rigidbody2D>().velocity = vel;

            UnityEngine.Debug.Log("A key Has been pressed");
        }
        else if (!Input.anyKey)
            {
                var vel = GetComponent<Rigidbody2D>().velocity;           //declaration of variable for velocity "vel"
            vel.x = 0.0f;
            vel.y = 0.0f;
                GetComponent<Rigidbody2D>().velocity = vel;
            }
        
       
    }
}
