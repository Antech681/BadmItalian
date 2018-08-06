using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour {

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

    // Use this for initialization
    void Start () {
        gameOn = true;
        Instantiate(meatball);
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
            Invoke("RoundRestart", 1f);
        }
        if (p1RoundScore == roundCap || p2RoundScore == roundCap)
        {
            EndGame();
            gameOn = false;
        }
    }

    public void RoundRestart()
    {
        Debug.Log("BADA BING");
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
        Debug.Log("BADA BOOM");
    }

    public void EndGame()
    {
        Debug.Log("End Game");
    }
}
