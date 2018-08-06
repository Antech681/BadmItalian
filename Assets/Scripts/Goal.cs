using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
    
    public int score;
    public Meatball meatball;
    public ParticleSystem splatter;
    public GameplayManager gameManager;

    // ADDED CODE HERE!!!!!!!!!!!!!!!!!!!!
    private Meatball meatballInPlay;
    public int howMuchToScore;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    // ADDED CODE HERE!!!!!!!!!!!!!!!!!!!!
    void Update () {
        meatballInPlay = FindObjectOfType<Meatball>();
        if (meatballInPlay == null)
        {
            return;
        }
        howMuchToScore = meatballInPlay.scoreWorth;
	}

    private void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Meatball")
        {
            score += howMuchToScore; // ADDED CODE HERE!!!!!!!!!!!!!!!!!!!!
            gameManager.Invoke("CheckScore", 0.1f);
            Destroy(other.gameObject);
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
