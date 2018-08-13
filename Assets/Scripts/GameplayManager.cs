using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour {

    public static GameplayManager GM;
    
    private SFXManager sfxMan;

    public GameObject pot1;
    public GameObject pot2;

    public Sprite dirty01;
    public Sprite dirty02;
    public Sprite dirty03;
    public Sprite dirty04;
    public Sprite dirty05;
    public Sprite dirty06;
    public Sprite otherDirty01;
    public Sprite otherDirty02;
    public Sprite otherDirty03;
    public Sprite otherDirty04;
    public Sprite otherDirty05;
    public Sprite otherDirty06;

    public Meatball meatball;

    public Goal leftGoal;
    public Goal rightGoal;

    public Text p1ScoreText;
    public Text p2ScoreText;
    private string p1ScoreString;
    private string p2ScoreString;

    private int p1Score;
    private int p2Score;

    public ServeTimer serveTimer;

    public int scoreCap;
    public int p1RoundScore;
    public int p2RoundScore;
    public int roundCap;

    public bool gameOn;
    
    public float[] serveHorizontal = new float[2] { -10, 10 };
    public float whichDirection;

    // Use this for initialization
    void Start () {
        gameOn = true;
        Instantiate(meatball);
        sfxMan = FindObjectOfType<SFXManager>();
        whichDirection = serveHorizontal[Random.Range(0, 2)];
    }
	
	// Update is called once per frame
	void Update () {
        if (gameOn)
        {
            p1Score = rightGoal.score;
            p2Score = leftGoal.score;

            p1ScoreString = p1Score.ToString();
            p2ScoreString = p2Score.ToString();

            p1ScoreText.text = p1ScoreString;
            p2ScoreText.text = p2ScoreString;

            if (p1RoundScore == roundCap || p2RoundScore == roundCap)
            {
                EndGame();
                gameOn = false;
            }
        }
    }

    public void InstTimer()
    {
        if (gameOn)
        {
            serveTimer.StartCountdown();
        }
    }

    public void CheckScore()
    {
        if (p1Score >= scoreCap || p2Score >= scoreCap)
        {
            sfxMan.roundVictory.Play();
            Invoke("RoundRestart", 2f);
        }
        /*if (p2Score == 1)
        {
            pot1.GetComponent<SpriteRenderer>().sprite = dirty01;
        }
        if (p2Score == 2)
        {
            pot1.GetComponent<SpriteRenderer>().sprite = dirty02;
        }
        if (p2Score == 3)
        {
            pot1.GetComponent<SpriteRenderer>().sprite = dirty03;
        }
        if (p2Score == 4)
        {
            pot1.GetComponent<SpriteRenderer>().sprite = dirty04;
        }
        if (p2Score == 5)
        {
            pot1.GetComponent<SpriteRenderer>().sprite = dirty05;
        }
        if (p2Score == 6)
        {
            pot1.GetComponent<SpriteRenderer>().sprite = dirty06;
        }
        if (p1Score == 1)
        {
            pot2.GetComponent<SpriteRenderer>().sprite = otherDirty01;
        }
        if (p1Score == 2)
        {
            pot2.GetComponent<SpriteRenderer>().sprite = otherDirty02;
        }
        if (p1Score == 3)
        {
            pot2.GetComponent<SpriteRenderer>().sprite = otherDirty03;
        }
        if (p1Score == 4)
        {
            pot2.GetComponent<SpriteRenderer>().sprite = otherDirty04;
        }
        if (p1Score == 5)
        {
            pot2.GetComponent<SpriteRenderer>().sprite = otherDirty05;
        }
        if (p1Score == 6)
        {
            pot2.GetComponent<SpriteRenderer>().sprite = otherDirty06;
        }*/
    }

    public void RoundRestart()
    {
        if (p1Score > p2Score)
        {
            p1RoundScore += 1;
        }
        else if (p1Score < p2Score)
        {
            p2RoundScore += 1;
        }
        rightGoal.score = 0;
        leftGoal.score = 0;
    }

    public void EndGame()
    {
        Debug.Log("End Game");
        //Insert endgame code here
    }
}
