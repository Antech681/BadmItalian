using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour {

    public Goal leftGoal;
    public Goal rightGoal;

    public Text p1ScoreText;
    public Text p2ScoreText;

    public int p1Score;
    public int p2Score;

    public string currentWinner;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        p1Score = rightGoal.score;
        p2Score = leftGoal.score;

        //p1ScoreText = p1ScoreString;

        if (p1Score == p2Score)
        {
            currentWinner = "It's a Draw";
        }
        else if (p1Score > p2Score)
        {
            currentWinner = "Player 1 (Left)";
        }
        else if (p1Score < p2Score)
        {
            currentWinner = "Player 2 (Right)";
        }
    }
}
