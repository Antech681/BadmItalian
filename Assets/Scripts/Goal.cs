﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WhichGoal
{
    LeftGoal,
    RightGoal
}

public class Goal : MonoBehaviour {

    public WhichGoal whichGoal;

    public int score;
    public Meatball meatball;
    public ParticleSystem splatter;
    public GameplayManager gameManager;

    // ADDED CODE HERE!!!!!!!!!!!!!!!!!!!!
    private Meatball meatballInPlay;
    public int howMuchToScore;

    // Update is called once per frame
    // ADDED CODE HERE!!!!!!!!!!!!!!!!!!!!
    void Update()
    {
        meatballInPlay = FindObjectOfType<Meatball>();
        if (meatballInPlay == null)
        {
            return;
        }
        howMuchToScore = meatballInPlay.scoreWorth;
    }
    
    /*public RectTransform playerBar;
    public float maxDirty;
    public float currentDirty = 0;
    private float dirty;*/

    // Use this for initialization
    void Start () {
        //maxDirty = playerBar.sizeDelta.x;
        //playerBar.sizeDelta = new Vector2(currentDirty, playerBar.sizeDelta.y);
        //dirty = maxDirty / 6;
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Meatball")
        {
            score += howMuchToScore; // ADDED CODE HERE!!!!!!!!!!!!!!!!!!!!
            gameManager.Invoke("CheckScore", 0.1f);
            //playerBar.sizeDelta = new Vector2(playerBar.sizeDelta.x + dirty, playerBar.sizeDelta.y);
            //Instantiate(splatter, other.gameObject.transform);
            Destroy(other.gameObject);
            switch (whichGoal)
            {
                case WhichGoal.LeftGoal:
                    gameManager.whichDirection = gameManager.serveHorizontal[1];
                    gameManager.serveTo = 2;
                    break;

                case WhichGoal.RightGoal:
                    gameManager.whichDirection = gameManager.serveHorizontal[0];
                    gameManager.serveTo = 1;
                    break;
            }
            if (gameManager.gameOn)
            {
                Invoke("InstantiateMeatball", 2);
            }
        }
    }

    private void InstantiateMeatball()
    {
        if (gameManager.gameOn)
        {
            Instantiate(meatball);
        }
    }
}
