using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        GoBall();
    }
    void GoBall()
    {
        float rand = UnityEngine.Random.Range(-1.0f, 1.0f);
        if (rand < 0.0f)
        {
            //push to right
            GetComponent<Rigidbody2D>().AddForce(new Vector2(120.0f, -100.0f));
            UnityEngine.Debug.Log("A positive number has been generateed");
        }
        else if (rand > 0.0f)
        {
            //push to left
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-120.0f, -100.0f));
            UnityEngine.Debug.Log("A negative number has been generateed");

            
        }

        //Invoke("GoBall", 2F);
    }
    // Update is called once per frame


        public void ResetBall()
    {
        //reposition ball to the center



        //2 Stop the ball
        var vel = GetComponent<Rigidbody2D>().velocity;
        vel.x = 0.0f;
        vel.y = 0.0f;
        GetComponent<Rigidbody2D>().velocity = vel;

        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        //3 push the ball in a random direction
        

        GoBall();
    }
    public void hasWon()
    {
        //reposition ball to the center
        float randY = UnityEngine.Random.Range(-4.5f, 4.5f);
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);

        //2 Stop the ball
        var vel = GetComponent<Rigidbody2D>().velocity;
        vel.x = 0.0f;
        vel.y = 0.0f;
        GetComponent<Rigidbody2D>().velocity = vel;


    }
    void Update()
    {
        
    }
    
}
