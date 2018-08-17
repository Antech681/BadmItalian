using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum WhichPlayerStars
{
    P1,
    P2
}

public class RoundStars : MonoBehaviour {

    public WhichPlayerStars whichPlayer;
    private GameplayManager gameManager;
    public Sprite currentSprite;
    public Sprite stars0;
    public Sprite stars1;
    public Sprite stars2;
    public Sprite stars3;
    public int roundScore;

	// Use this for initialization
	void Start () {
        gameManager = FindObjectOfType<GameplayManager>();
        UpdateStars();
	}
	
	// Update is called once per frame
	void Update () {
        switch (whichPlayer)
        {
            case WhichPlayerStars.P1:
                roundScore = gameManager.p1RoundScore;

                break;

            case WhichPlayerStars.P2:
                roundScore = gameManager.p2RoundScore;

                break;
        }
	}

    public void UpdateStars()
    {
        if (roundScore == 0)
        {
            currentSprite = stars0;
        }
        if (roundScore == 1)
        {
            currentSprite = stars1;
        }
        if (roundScore == 2)
        {
            currentSprite = stars2;
        }
        if (roundScore == 3)
        {
            currentSprite = stars3;
        }
        GetComponent<SpriteRenderer>().sprite = currentSprite;
    }
}
