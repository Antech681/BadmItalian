using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour {

    public Goal leftGoal;
    public Goal rightGoal;

    public Text p1ScoreText;
    public Text p2ScoreText;
    private string p1ScoreString;
    private string p2ScoreString;

    private int p1Score;
    private int p2Score;

    public ServeTimer serveTimer;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        p1Score = rightGoal.score;
        p2Score = leftGoal.score;

        p1ScoreString = p1Score.ToString();
        p2ScoreString = p2Score.ToString();

        p1ScoreText.text = p1ScoreString;
        p2ScoreText.text = p2ScoreString;
    }

    public void InstTimer()
    {
        serveTimer.StartCountdown();
    }
}
