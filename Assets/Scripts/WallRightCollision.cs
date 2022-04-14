using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class WallRightCollision : MonoBehaviour
{

   public Score score;
    public AudioClip laser;
    AudioSource audioSource;
    void OnTriggerEnter2D(Collider2D Ball)
    {

       Ball.gameObject.GetComponent<BallMovement>().ResetBall();

        score.AddScore();
        UnityEngine.Debug.Log("BAM RIGHTY HAS BEEN HIT MAYDAY");
        // 1 pt to other player

        float randY = UnityEngine.Random.Range(-5.15f, 5.15f);
        Ball.gameObject.transform.position = new Vector3(0.0f, randY, 0.0f);


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
