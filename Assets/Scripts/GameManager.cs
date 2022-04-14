
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    // Start is called before the first frame update
    public destroyOnContact ScorePoints;
    public int lives;
    public static int score;
    public int TheScore;
    public Text livesText;
    public Text scoreText;
    public Text GameOver;
    public Text PlayerWins;
    public Transform Lvl1;
    public Transform Lvl2;

    bool Lvl2On = false;
    void Start()
    {
          resetScore();
        Ball = GameObject.Find("Ball");
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + score;
        Instantiate(Lvl1, new Vector3(404.0f, 74.3f, 1.779297f), Quaternion.identity);
        //Instantiate(Lvl2, new Vector3(404.0f, 74.3f, 1.779297f), Quaternion.identity);
    }
   
    // Update is called once per frame
    void Update()
    {
        print(score);

        
        if (score == 56)
        {
            UnityEngine.Debug.Log("Idky its not working");
            PlayerWins.text = "You Win!";
            Invoke("changeScene", 4f);
            Invoke("ButtonShow", 2F);
            Ball.GetComponent<BallMovement>().hasWon();
        }
        if (score == 21)
        {
           
            UnityEngine.Debug.Log("Its working!");
            if (Lvl2On == false)
            {


                GameManager.Instantiate(Lvl2, new Vector3(404.0f, 74.3f, 1.779297f), Quaternion.identity);
                Lvl2On = true;
                gameOver();
            }

        }
        
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + score;
    }
    public void updateLives(int changeInLives)
    {

        lives += changeInLives;
        gameOver();

    }

    
    public GameObject Ball;
    public GameObject REStartButton;

    // Start is called before the first frame update
    void changeScene()
    {
        GetComponent<SceneChange>().changeScene();
    }


    public void ButtonShow()
    {
        REStartButton.SetActive(true);
    }
    public void gameOver()
    {
        if (lives == 0)
        {
            GameOver.text = "Game Over!";
            //FindObjectOfType<GameManager>().EndGame();
            Ball.GetComponent<BallMovement>().hasWon();
            Invoke("changeScene", 4f);
            Invoke("ButtonShow", 2F);
          
            
        }
        else
        {
            Ball.GetComponent<BallMovement>().ResetBall();

        }
    }
   
    public void AddScore()
    {
        score++;
        scoreText.text = "Score:" + score;

        gameOver();
    }
     public void resetScore()
    {
        score = 0;
        scoreText.text = "Score:" + score;
    }




}
