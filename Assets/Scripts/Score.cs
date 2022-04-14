using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text Scoreboard;
    public Text GameOver;

     int livesLeft = 0;
     int score = 0;
    public GameObject Ball;
    public GameObject REStartButton;

    // Start is called before the first frame update
    void Start() {
        {
        
            Ball = GameObject.Find("Ball");
        }
    }
    void changeScene()
    {
        GetComponent<SceneChange>().changeScene();
    }
    

    public void ButtonShow()
    {
        REStartButton.SetActive(true);
    }
    void gameOver()
    {
        if (score == 10)
        {
            //theBall.SendMessage("hasWon");
            GameOver.text = "Player 1 Wins!";
            //FindObjectOfType<GameManager>().EndGame();
            Ball.GetComponent<BallMovement>().hasWon();
            Invoke("changeScene", 4f);
            Invoke("ButtonShow", 2F);
        }
        else if (livesLeft == 0)
        {
            GameOver.text = "Game Over!";
            //FindObjectOfType<GameManager>().EndGame();
            Ball.GetComponent<BallMovement>().hasWon();
            Invoke("changeScene", 4f);
            Invoke("ButtonShow", 2F);
            score = 0;
            resetScore();
        }
        else
        {
            Ball.GetComponent<BallMovement>().ResetBall();

        }
    }

   

    // Update is called once per frame
    void Update()
    {
        print(score);
    }

    public void AddScore()
    {
        score++;
        Scoreboard.text = "Score:" + score;

        gameOver();
    }
    public void resetScore()
    {
        score = 0;
        Scoreboard.text = "Score:" + score;
    }
   
    
    

}
