using System.Collections;
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

    public Sprite meatball1;
    public Sprite meatball2;
    public Sprite meatball3;

    // ADDED CODE HERE!!!!!!!!!!!!!!!!!!!!
    private Meatball meatballInPlay;
    public int howMuchToScore;

    // Use this for initialization
    void Start()
    {
        maxDirty = playerBar.sizeDelta.x;
        playerBar.sizeDelta = new Vector2(currentDirty, playerBar.sizeDelta.y);
        dirty = maxDirty / 6;
        gameManager = FindObjectOfType<GameplayManager>();
    }

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
    public RectTransform playerBar;
    public RectTransform otherPlayerBar;
    public float maxDirty;
    public float currentDirty = 0;
    private float dirty;

    // Use this for initialization
    void Start () {
        maxDirty = playerBar.sizeDelta.x;
        playerBar.sizeDelta = new Vector2(currentDirty, playerBar.sizeDelta.y);
        dirty = maxDirty / 6;
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Meatball")
        {
            score += howMuchToScore; // ADDED CODE HERE!!!!!!!!!!!!!!!!!!!!
            gameManager.Invoke("CheckScore", 0.1f);
            //playerBar.sizeDelta = new Vector2(playerBar.sizeDelta.x + dirty, playerBar.sizeDelta.y);
            if (Meatball.meatballWorth == 1)
            {
                playerBar.sizeDelta = new Vector2(playerBar.sizeDelta.x + dirty, playerBar.sizeDelta.y);
                Debug.Log("Meatball 1");
            }
            if (Meatball.meatballWorth == 2)
            {
                playerBar.sizeDelta = new Vector2(playerBar.sizeDelta.x + (dirty*2), playerBar.sizeDelta.y);
                Debug.Log("Meatball 2");
            }
            if (Meatball.meatballWorth == 3)
            {
                playerBar.sizeDelta = new Vector2(playerBar.sizeDelta.x + (dirty*3), playerBar.sizeDelta.y);
                Debug.Log("Meatball 3");
            }
            if (playerBar.sizeDelta.x >= maxDirty)
            {
                playerBar.sizeDelta = new Vector2(currentDirty, playerBar.sizeDelta.y);
                otherPlayerBar.sizeDelta = new Vector2(currentDirty, otherPlayerBar.sizeDelta.y);
            }
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
